using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesseon7EncapsulationAnother;
using AnotherAssembly;

namespace CsharpTraining6_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            // public, private, internal, protected, internal protected
            // assembly vs namespace
            Person person = new Person();
            Console.WriteLine(person.GetAge());
            AnotherNamespaceClass anc = new AnotherNamespaceClass();
            Console.WriteLine(anc.internalString);

            Man man = new Man();
            Console.WriteLine(man.GetPersonName());

            Console.ReadLine();
        }
    }

    class Person
    {
        private int age;

        protected string name = "PersonName";

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

    class Man : Person
    {
        public string GetPersonName()
        {
            return base.name;
        }
    }
}