using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog(); //先輸出父類別，再輸出子類別
            //dog.Age = 10;
            //dog.Bite();
            //dog.GetAge();
            //dog.BiteMan();

            //Dog oldDog = new Dog(10);

            Animal dog = new Dog();
            dog.Bite();
            ((Dog)dog).BiteMan(); //強制轉換為子類別

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

        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }

        public Animal(int age)
        {
            Console.WriteLine("Old Animal");
            this.Age = age;
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
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }

        public Dog(int age)
        {
            Console.WriteLine("Old Dog");
            this.Age = age;
        }

        public override void Bite()
        {
            Console.WriteLine("Dog bite");
        }

        public new void BiteMan()
        {
            Console.WriteLine("Dog bite man");
        }
    }
}
