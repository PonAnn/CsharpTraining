using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iToBoxing = 100;
            object iBoxed = iToBoxing;

            int iUnboxing = (int)iBoxed;
            object nullObject = 5;
            int iNull = (int)nullObject;

            Console.ReadLine();
        }
    }
}
