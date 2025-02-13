using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining8_2
{
    class Program
    {
        static void Main(string[] args)
        {

            complex c1 = new complex();
            complex c2 = new complex();
            c1.Number = 2;
            c2.Number = 3;
            Console.WriteLine((c1 + c2).Number);

            Human human1 = new Man();
            Human human2 = new Woman();
            human1.CleanRoom();
            human2.CleanRoom();

            Console.WriteLine(c2);

            Console.ReadLine();
        }
    }

    class complex
    {
        public int Number { get; set; }
        public static complex operator +(complex c1, complex C2)
        {
            complex c = new complex();
            c.Number = c1.Number + C2.Number;

            return c;
        }

        public override string ToString()
        {
            return Number.ToString();
        }
    }

    class Human
    {
        public virtual void CleanRoom()
        {
            Console.WriteLine("Human Clean Room");
        }
    }

    class Man : Human
    {
        public override void CleanRoom()
        {
            Console.WriteLine("Man clean room  slowly");
        }
    }

    class Woman : Human
    {
        public override void CleanRoom()
        {
            Console.WriteLine("Woman clean room quickly");
        }
    }


        
}
