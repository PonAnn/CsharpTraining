using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Age = 10;
            dog.Bite();
            dog.GetAge();
            dog.BiteMan();

            Console.ReadLine();
        }
    }

    class Animal
    {
        public int Age
        {
            get;
            set;
        }

        public virtual void Bite()
        {
            Console.WriteLine("Animal bite"); 
        }

        public virtual void GetAge()
        {
            Console.WriteLine(Age);
        }

        public void BiteMan()
        {
            Console.WriteLine("Animal bite man");
        }
    }

    class Dog : Animal
    {
        public override void Bite()
        {
            Console.WriteLine("Dog bite");
        }
        public void BiteMan()
        {
            Console.WriteLine("Dog bite man");
        }
    }
}
