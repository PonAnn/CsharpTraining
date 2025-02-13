using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ae = new ArgumentException(); // 參數異常
            var ane = new ArgumentNullException();  //空值的異常
            var aore = new ArgumentOutOfRangeException(); //範圍內的異常
            var dne = new DirectoryNotFoundException(); //在IO下的，找不到路徑的異常
            var fne = new FileNotFoundException(); // 在IO下的，找不到檔案的異常
            var ioe = new InvalidOperationException(); //非法運算符異常
            var nie = new NotImplementedException(); // 未實現異常
        }
    }
}
