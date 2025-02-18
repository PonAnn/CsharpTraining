using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;
            bool a = true;
            // System.ValueType // System.Object 是C#語言的基類，所有的數據類型都會繼承於他
            // 變數由多個單字組成時，單字的第一個字母都要大寫。方法第一個單字要大寫(Main)
            int intValue = 0; // C#裡，int的初始化數值為0
            int intValue2 = new int(); // 此行與上一行相同意思
            Console.WriteLine("HelloWorld123");
            Console.WriteLine(intValue2);
        }
    }
}
