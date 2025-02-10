using System;
using System.Collections;
using System.Collections.Generic;

namespace CsharpTraining5_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Hashtable 沒有分類型
            Hashtable ht = new Hashtable();
            ht.Add("first", "jike");
            ht.Add("second", "xueyuan");
            Console.WriteLine(ht["second"]);
            Console.WriteLine(ht[100]);
            // 如果沒有這個鍵，輸出為空
            Console.WriteLine(ht[99]);


            // Dictionary 有分類型，強類型
            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("first", "jike");
            // 如果沒有這個值，會噴錯
            // Console.WriteLine(d["99"]);

            // SortedList 會根據 key 值做排序
            SortedList<int, int> sl = new SortedList<int, int>();
            sl.Add(5, 105);
            sl.Add(2, 102);
            sl.Add(10, 99);
            foreach (var sle in sl)
            {
                Console.WriteLine(sle);
            }


            // stack (後進先出), queue (先進先出)

            Console.ReadLine();
        }
    }
}