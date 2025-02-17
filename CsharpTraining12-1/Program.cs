using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining12_1
{
    delegate int NumberChanger(int n);
    class Program
    {
        static int num = 10;
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            nc1(25);

            Console.WriteLine("Value of Num: {0}", num);
            Console.ReadLine();
        }

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
    }
}
