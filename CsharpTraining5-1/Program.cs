using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Array

            int[] number = new int[5];
            string[,] names = new string[5, 4];
            byte[][] scores = new byte[5][];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }

            int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };
            int[] numbers3 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers4 = { 1, 2, 3, 4, 5 };

            string[,] names2 = { { "g", "k" }, { "h", "j" } };
            int[][] numberss = { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6, 7 } };

            Console.WriteLine(numbers2[2]);
            Console.WriteLine(numbers2.Length);
            // IEmunerable, Iemunerator

            foreach (int i in numbers2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
