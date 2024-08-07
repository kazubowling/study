﻿using System;
using System.Threading;
using System.Threading.Tasks;

//class A
//{
//    public static void Main()
//    {
//        Console.WriteLine("{1} - {0}は{2}です。", 2, 3, 3 - 2);
//    }    
//}

//class FormatSample
//{
//    static void Main()
//    {
//        Console.WriteLine("C {0, 6:C}", 1234);
//        Console.WriteLine("D {0, 6:D}", 123);
//        Console.WriteLine("E {0, 6:E}", 123.45);
//        Console.WriteLine("F {0, 6:F}", 123);
//        Console.WriteLine("G {0, 6:G}", 123);
//        Console.WriteLine("N {0, 10:N}", 123456);
//        Console.WriteLine("P {0, 6:P}", 123);
//        Console.WriteLine("X {0, 6:X}", 123);

//        int a = 10;
//        double b = 20.5;
//        //Console.WriteLine("{0} + {1} は、{2}です。", a, b, 1 + b);

//        Console.WriteLine($"{a} + {b}は、{a + b}です。");

//        string a;
//        a = String.Format("{0}の{1}", "C#", "絵本");
//        Console.WriteLine(a);
//    }
//}

//class DTSample
//{
//    static void Main()
//    {
//        DateTime dt = DateTime.Now;

//        Console.WriteLine("今日は{0}年{1}月{2}日({3})で、", dt.Year, dt.Month, dt.Day, dt.DayOfWeek);
//        Console.WriteLine("現在{0}時{1}分{2}秒です", dt.Hour, dt.Minute, dt.Second);
//    }
//}

class MainClass
{
    static async Task<int> ProcAsync()
    {
        Random r = new Random();
        int sum = 0;
        await Task.Run(() =>
        {
            for (int i = 0; i <= 10; i++)
            {
                int x = r.Next(100);
                Console.WriteLine("ランダムな数値：" + x.ToString());
                sum = sum + x;
                Thread.Sleep(1000);
            }
        });

        Console.WriteLine("ProcAsync() 終了");
        return (sum);
    }

    static async Task MainProcAsync()
    {
        Console.WriteLine("キーを押すと終了します。");
        int sum = await ProcAsync();
        Console.WriteLine("ランダムな数値の合計：" + sum.ToString());
    }

    static void Main(string[] args)
    {
        MainProcAsync();
        Console.ReadKey();
    }
}