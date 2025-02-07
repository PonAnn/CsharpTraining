using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(5);
            Console.WriteLine(person.GetAge());
            Console.WriteLine(Person.GetSix());
            Console.WriteLine(person.Age);
            person.Age = 10;
            Console.WriteLine(person.GetAge());
            Console.ReadLine();
        }
    }
    class Person
    {
        int age; //變數

        public int Age //屬性(屬性透過 get / set 存取)
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
        public Person(int myAge) //建構函式(用來初始化物件)
        {
            this.age = myAge; //this可省略 
        }
        public int GetAge() //方法
        {
            return age;
        }

        public static int GetSix() //靜態方法
        {
            return 6;
        }
    }
}
