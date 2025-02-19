using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.Message("In Main function");
            Function1();
            Console.ReadLine();
        }

        //過時的Attribute，不再使用
        //[Obsolete("Don't use Old Method!", true)]

        static void Function1()
        {
            MyClass.Message("In Function1");
            Function2();
        }

        static void Function2()
        {
            MyClass.Message("In Function2");
        }
    }

    public class MyClass
    {
        // Attribute
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
