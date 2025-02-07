using System;
using System.Text;

namespace CsharpTraining2_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // object, string, dynamic
            // System.Object, System.string, System.Dynamic
            object o = new object();
            object o2 = new object();
            Console.WriteLine(o.GetType());
            Console.WriteLine(o.ToString());
            Console.WriteLine(o);
            int i = 5;
            Console.WriteLine(i.ToString());

            string s = "jikexueyuan";
            string s2 = "jike";
            s2 += "xueyuan";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(s == s2);
            Console.WriteLine((object)s == (object)s2);
            char c = s[2]; // char用來放單個字元
            Console.WriteLine(c);
            string u = "\\\u0066\n"; // \\代表字串中的反斜線\，\是特殊字元，\u0066代表unicode編碼=f \n代表換行
            Console.WriteLine(u);
            string at = @"C:\jikexueyuan\hello.cs"; // @會忽略跳脫字元，讓""裡面的字是字符 不會轉成編碼
            Console.WriteLine(at);
            string noAt = "C:\\jikexueyuan\\hello.cs";
            Console.WriteLine(noAt); // 沒有@就需要用兩個\\來包
            at.Contains("jike");
            Console.WriteLine(at.Length); // at""內的長度
            Console.WriteLine(at.IndexOf("ji"));

            StringBuilder builder = new StringBuilder(); //StringBuilder代表可變字串，效能比string好
            builder.Append("jike"); //apend會把新字串加到後面
            builder.Append("xueyuan");
            Console.WriteLine(builder);
            builder.AppendFormat(" hello{0} {1}", "jikexueyuan", "world");
            Console.WriteLine(builder);
            Console.ReadLine();
        }
    }
}