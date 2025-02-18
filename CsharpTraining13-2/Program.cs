using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining13_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var e = new EventTest(5);
            e.SetValue(100);
            e.ChangeNum += new EventTest.NumManipulationHandler(EventTest.EventFired);
            e.SetValue(200);

            Console.ReadLine();
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
}
