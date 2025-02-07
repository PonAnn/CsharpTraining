using System;

namespace CsharpTraining2_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person(25);

            Console.WriteLine(person.Age);

            Console.ReadLine();
        }
    }

    #region Person

    internal class Person : Man, ISuper
    {
        public int age;

        public int Age
        {
            get
            {
                return age + 10;
            }
            set
            {
                age = value - 10;
            }
        }

        public Person(int myAge)
        {
            this.age = myAge; //this可省略
        }

        public int GetAge()
        {
            return age;
        }

        public static int GetSix() //靜態方法
        {
            return 6;
        }

        public int GetSuper()
        {
            return age + 100;
        }

        public override int GetAbstract()
        {
            return 50;
        }
    }

    #endregion Person

    internal abstract class Man
    {
        public string name;

        public string GetName()
        {
            return name;
        }

        public abstract int GetAbstract();
    }

    internal interface ISuper
    {
        int GetSuper();
    }
}