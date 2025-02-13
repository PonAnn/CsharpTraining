using System;
using System.IO;

namespace CsharpTraining10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 判斷檔案或目錄是否存在
            // Console.WriteLine(File.Exists(@"C:\HelloIO\IO.txt"));
            // Console.WriteLine(Directory.Exists(@"C:\"));

            string path = ".";
            if (args.Length > 0)
            {
                if (Directory.Exists(args[0]))
                {
                    path = args[0];
                }
                else
                {
                    Console.WriteLine("{0} not found; using current direvtory:", args[0]);
                }
            }

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach(FileInfo f in dir.GetFiles("*.exe"))
            {
                string name = f.Name;
                long size = f.Length;
                DateTime creationTime = f.CreationTime;
                Console.WriteLine("{0,-12:NO} { 1, -20:g} {2}", size, creationTime, name);
            }

            Console.ReadLine();
        }
    }
}
