using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            // 產生亂數物件
            Random rand = new Random();

            // 字體顏色
            Console.ForegroundColor = ConsoleColor.Green;

            // 重複產生
            while (true)
            {
                // 產生六個亂數
                int a1 = rand.Next(1, 43);
                int a2 = rand.Next(1, 43);
                int a3 = rand.Next(1, 43);
                int a4 = rand.Next(1, 43);
                int a5 = rand.Next(1, 43);
                int a6 = rand.Next(1, 43);

                // 顯示亂數
                Console.WriteLine("號碼:{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", a1, a2, a3, a4, a5, a6);

            }
           
            // 暫停螢幕
            Console.ReadLine();
        }
    }
}
