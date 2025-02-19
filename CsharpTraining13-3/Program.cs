using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining13_3
{
    class Program
    {
        // 建議的寫法
        public delegate void ChangedEventHandler(object sender, EventArgs e);
        static void Main(string[] args)
        {
            //最好使用這種方式
            //EventHandler

            var e = new EventTest(5);
            e.SetValue(100);
            e.ChangeNum += new EventTest.NumManipulationHandler(EventTest.EventFired);
            e.SetValue(200);

            I i = new Myclass();
            i.MyEvent += new MyDelegate(f);
            i.FireAway();

            Console.ReadLine();
        }

        private static void f()
        {
            Console.WriteLine("This is called whene the event fired");
        }
    }

    class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangeNum;

        public EventTest(int n)
        {
            SetValue(n);
        }

        public static void EventFired()
        {
            Console.WriteLine("Binded Event fired");
        }

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("Event fired!");
            }
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
            }
        }

    }

    public delegate void MyDelegate();

    public interface I
    {
        event MyDelegate MyEvent;
        //較好的格式
        event EventHandler MyGuidlineEvent;
        void FireAway();
    }

    public class Myclass : I
    {
        public event MyDelegate MyEvent;
        public event EventHandler MyGuidlineEvent;

        public void FireAway()
        {
            if (MyEvent != null)
                MyEvent();
        }
    }
}
