using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining1_2
{
    enum Days { Monday, Tuesday, Wenesday, Thursday, Friday, Saturday, Sunday}
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.age = 10;
            Console.WriteLine(person.age);

            var day = Days.Thursday;
            Console.WriteLine(day);
            Console.ReadLine();
        }

        struct Person
        {
            // 主要有四種存取修飾詞(訪問修飾符)
            public int age; // public 對外公開
            private string name; // 私有的
            internal string fname; // 內部可以存取
            // protected string lastName; // 受保護的
        }
    }
}
