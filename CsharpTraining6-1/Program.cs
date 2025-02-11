using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //public, private, internal, protected, internal protected
            Person person = new Person();
            Console.WriteLine(person.GetAge());

            Console.ReadLine();
        }


    }

    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int GetAge()
        {
            if (CheckAge())
            {
                return age;
            }

            return -1;
        }

        private bool CheckAge()
        {
            if (age <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
