using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collection

            // ArrayList，沒有分int或string，較不推薦
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add(100);
            al.Remove(5);
            al.Add("jikexueyuan");

            foreach (var e in al)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(al[0]);


            // 更推薦List
            List<int> intList = new List<int>();
            intList.Add(500);
            intList.AddRange(new int[] { 501, 502 });
            Console.WriteLine(intList.Contains(200));
            Console.WriteLine(intList.IndexOf(501));
            intList.Remove(501);
            intList.Insert(1, 1001);

            Console.ReadLine();
        }
    }
}
