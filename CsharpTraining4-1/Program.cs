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

            // if else 簡寫
            ten = 30;
            int ifelse = ten < 100 ? ten : 99; //if ten<100 則 ten=30，若>100，回傳 ? 後的數值
            Console.WriteLine(ifelse);

            // else if 太多可以簡寫如下
            int switchKey = 100;
            switch (switchKey)
            {
                case 10: // 如果 = 10 則執行下面這行
                    Console.WriteLine("switchKey is 10");
                    break;
                case 100:
                    Console.WriteLine("switchKey is 100");
                    break;
                default:
                    Console.WriteLine("I don't know switch key");
                    break;
            }



            Console.ReadLine();
        }
    }
}
