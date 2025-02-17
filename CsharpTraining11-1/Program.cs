using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new IndexedNames();
            names[0] = "Hello";
            names[1] = "jikexueyuan";
            names[2] = "we";
            names[3] = "are";
            names[4] = "learning";
            names[5] = "C#";
            names[6] = "Indexer";
            names[7] = "-";
            names[8] = "Indexer";
            names[9] = "Syntax";

            for (int i = 0; i <=9; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadLine();
        }
    }
    
    class IndexedNames
    {
        private string[] nameList = new string[10];
        public IndexedNames()
        {
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = "N/A";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }

                return tmp;
            }
            set
            {
                if (index >= 0 && index <= nameList.Length - 1)
                {
                    nameList[index] = value;
                }
            }
        }

    }

    // 語意不合理的例子
    class Employee
    {
        public double this[int year]
        {
            get
            {
                // return salary;
                return 0;
            }
        }
    }


}
