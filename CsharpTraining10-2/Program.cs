using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsharpTraining10_2
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";
        static void Main(string[] args)
        {
            /*
            // 透過 FileStream 及 StreamWriter 創建 / 寫入
            if (File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} already exists!", FILE_NAME);
                Console.ReadLine();
                return;
            }

            // FileStream 創建文件
            FileStream fs = new FileStream(FILE_NAME, FileMode.Create);
            // BinaryWriter 寫入文件
            BinaryWriter w = new BinaryWriter(fs);

            for (int i = 0; i < 11; i++)
            {
                w.Write("a");
            }

            w.Close();
            fs.Close();
            */


            using (StreamWriter w = File.AppendText("test.txt"))
            {
                Log("hehe", w);
                Log("Hello jikexueyuan", w);

                w.Close();
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry:");
            w.WriteLine(" :{0}", logMessage);

            w.Flush();
        }
    }
}
