using System;

//class A
//{
//    public static void Main()
//    {
//        Console.WriteLine("{1} - {0}は{2}です。", 2, 3, 3 - 2);
//    }    
//}

class FormatSample
{
    static void Main()
    {
        //Console.WriteLine("C {0, 6:C}", 1234);
        //Console.WriteLine("D {0, 6:D}", 123);
        //Console.WriteLine("E {0, 6:E}", 123.45);
        //Console.WriteLine("F {0, 6:F}", 123);
        //Console.WriteLine("G {0, 6:G}", 123);
        //Console.WriteLine("N {0, 10:N}", 123456);
        //Console.WriteLine("P {0, 6:P}", 123);
        //Console.WriteLine("X {0, 6:X}", 123);

        int a = 10;
        double b = 20.5;
        //Console.WriteLine("{0} + {1} は、{2}です。", a, b, 1 + b);

        Console.WriteLine($"{a} + {b}は、{a + b}です。");
    }
}