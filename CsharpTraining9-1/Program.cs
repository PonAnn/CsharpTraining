using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            // try catch 除錯方法1
            try
            {
                int y = 100 / x;
            }
            // catch (Exception e) // 才能捕捉錯誤
            catch (NullReferenceException e) // 不會捕捉錯誤，錯誤會繼續跑
            {
                Console.WriteLine(e.Message);
                throw;
            }
            // 不管前面try有沒有成功執行，或是執行一半被catch或是執行一辦沒有被catch，都會執行finally
            // 一定會執行這行
            finally
            {
                Console.WriteLine("Anyway, we arrive here!");
            }
            // 前面已經出錯，這邊就不會執行了，如果有成功捕捉錯誤，這行才會執行
            Console.WriteLine("After try catch");

            // throw 除錯方法2
            // throw new NullReferenceException(); 
        }
    }
}
