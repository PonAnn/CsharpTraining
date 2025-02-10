using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining4_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region for loop

            //for (int i = 0; i <5; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("After condition");
            //}

            #endregion for loop

            int i;
            int j = 10;
            for (i = 0, Console.WriteLine("Start:{0}", i); i < j; i++, j--, Console.WriteLine("i={0}, j={1}", i, j))
            {
                Console.WriteLine("Body of the loop");
            }

            bool stop = false;
            for (; !stop; )
            {
                stop = true;
                Console.WriteLine("Can u stop");
            }

            // IEnumerable
            List<int> listInt = new List<int>() { 1, 2, 3 };
            foreach (var intInList in listInt)
            {
                Console.WriteLine(intInList);
            }


            // while 迴圈，
            int n = 1;
            while (n++ < 6)
            {
                Console.WriteLine("n is {0}", n);
            }

            //do while 迴圈，還沒判斷就先執行一次，所以最少有一次
            do
            {
                Console.WriteLine("time");
            }
            while (false);

            Console.ReadLine();
        }
    }
}