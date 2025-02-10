using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining3_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i = 10;
            string sFromI = i.ToString();
            int iFromS = Convert.ToInt32("100"); //字符串轉換為數字，若不能轉換則出現錯誤
            int iFromS2 = Int32.Parse("101");
            int iFromS3;
            bool succeed = Int32.TryParse("abcde", out iFromS3); // 若不能轉換則succeed變數會變成false，轉換為0，但不會報錯
            Console.WriteLine(iFromS3); //印出0
            // IConventible, TypeConventer

            Console.ReadLine();
        }

    }
}