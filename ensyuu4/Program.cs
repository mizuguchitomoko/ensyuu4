using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ensyuu4
{
    class Program
    {
        static void Main(string[] args)
        {
            //月を表す数値を入力し、その月の日数を表示するプログラムを作成しなさい。2 月は 28 日とします。
            //また、1 ～ 12 以外の数値が入力された場合に、“入力が間違っています”と表示しなさい。
            Console.WriteLine("月を入力せよ。日数を出します");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 2:
                    Console.WriteLine("28日です");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30日です");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31日です");
                    break;
                default:
                    Console.WriteLine("入力が間違っています");
                    break;
            }
        }
    }
}
