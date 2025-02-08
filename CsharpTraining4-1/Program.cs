using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            int ten = 10;

            // && 代表 和 
            // || 代表 或 
            if (ten > 100)
            {
                Console.WriteLine("True Condition");
                if (true)
                {
                    Console.WriteLine("True and True");
                }
            }
            else if (ten > 5)
            {
                Console.WriteLine("ten > 5 and ten < 100");
            }
            else
            {
                Console.WriteLine("ten <= 5");
            }



            Console.ReadLine();
        }
    }
}
