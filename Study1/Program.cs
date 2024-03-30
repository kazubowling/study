using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    class Study
    {
        //public static void Main()
        //{
        //プログラムを作る
        //console.WriteLine("Japan Airlines");

        //文字列の表示
        //Write()メソッド：()の中の文字列を画面に表示
        //Console.Write("Japan Airlines");

        //WriteLine()メソッド：()の中の文字列を画面に表示して改行する
        //Console.WriteLine("American Airlines");

        //変数の表示
        //int a;
        //int b;
        //a = 2;
        //b = 4;
        //a = b;

        //Console.WriteLine(a);


        //文字の表示
        //char a = 'A';
        //Console.WriteLine(a);

        //文字列の表示
        //string Airline = "Japan Airlines";
        //Console.WriteLine(Airline);

        //string airlines = "japan airlines";
        //int code = 311;

        //string flight = airlines + " " + code + "便";
        //console.writeline(flight);

        //配列
        //int[] a = new int[4];
        //int n = 3;
        //a[0] = 1;
        //a[1] = 2;
        //a[2] = 3;
        //a[3] = 4;

        //Console.WriteLine(a[n]);

        //int[] a = { 1, 2, 3, 4 };
        //Console.WriteLine(a[0]);
        //Console.WriteLine(a[1]);
        //Console.WriteLine(a[2]);
        //Console.WriteLine(a[3]);
        //}


        //コレクション Listの使い方(第1章)
        //public static void Main(string[] args)
        //{
        //    List<string> airlines = new List<string>() { "Japan Airlines", "American Airlines" };
        //    airlines.Add("Japan Airlines");
        //    airlines.Add("American Airlines");
        //    airlines.Add("All Nippon Airways");

        //    Console.WriteLine("airlines[0] = " + airlines[0]);
        //    Console.WriteLine("airlines[1] = " + airlines[1]);
        //    Console.WriteLine("airlines[2] = " + airlines[2]);
        //}
    }

    //第2章　演算子
    class study2
    {
        static void Main()
        {
            //Console.WriteLine("5 + 5は" + (5 + 5) + " です。");
            //Console.WriteLine("5 - 5は" + (5 - 5) + " です。");
            //Console.WriteLine("5 × 5は" + 5 * 5 + "です。");
            //Console.WriteLine("5 ÷ 5は" + 5 / 5 + " です。");
            //Console.WriteLine("5 ÷ 3の余りは" + 5 % 3 + " です。");

            int a = 90;
            a += 10;
            Console.WriteLine("90に10を足すと、" + a + "です。");
        }
    }
}