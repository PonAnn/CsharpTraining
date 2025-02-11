using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHello();
            PrintHello("world");

            complex c1 = new complex();
            complex c2 = new complex();
            c1.Number = 2;
            c2.Number = 3;
            Console.WriteLine((c1 + c2).Number);

            Console.ReadLine();
        }

        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }

        public static void PrintHello(string towho)
        {
            Console.WriteLine("Hello {0}", towho);
        }
    }

    class complex
    {
        public int Number { get; set; }
        public static complex operator + (complex c1, complex C2)
        {
            complex c = new complex();
            c.Number = c1.Number + C2.Number;

            return c;
        }
    }
}
