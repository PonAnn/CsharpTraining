using System;
using System.IO;

namespace CsharpTraining10_3
{
    class Program
    {
        private const string FILE_NAME = "Test.txt";
        static void Main(string[] args)
        {
            //// 先判斷文件是否存在
            if (!File.Exists(FILE_NAME))
            {
                Console.WriteLine("{0} does not exist!", FILE_NAME);
                Console.ReadLine();
                return;
            }

            // StreamReader 讀取資料
            using (StreamReader sr = File.OpenText(FILE_NAME))
            {
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }

                Console.WriteLine("The end of the stream");
                sr.Close();
            }

            Console.ReadLine();


            /*
            FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
            // BinaryReader 
            BinaryReader r = new BinaryReader(fs);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(r.ReadString());
            }

            r.Close();
            fs.Close();

            Console.ReadLine();
            */

        }
    }
}
