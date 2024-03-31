using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    //第1章　基本的なプログラム
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

            //int a = 90;
            //a += 10;
            //Console.WriteLine("90に10を足すと、" + a + "です。");

            //int a = 1;
            //Console.WriteLine("はじめは " + a  + " です。");

            //a++;
            //Console.WriteLine("1つ増えて " + a + " になりました。");

            //a--;
            //Console.WriteLine("1つ減って " + a + " に戻りました。");


            //a++と++aの違い
            //int a = 1;
            //int b = 1;

            //Console.WriteLine("前置だとaは " + ++a + " になります。");
            //Console.WriteLine("後置だとbは " + b++ + " になります。");


            //比較演算子
            //int a = 10, b = 20;
            //Console.WriteLine("a = " + a + " b = " +  b);
            //Console.WriteLine("a<b・・・" + (a < b));
            //Console.WriteLine("a>b・・・" + (a > b));
            //Console.WriteLine("a==b・・・" + (a == b));
            //Console.WriteLine("a=b・・・" + (a = b));


            //論理型
            //int a = 10, b = 20;
            //bool c, d, e;

            //c = a < b;
            //d = a > b;
            //e = a == b;
            //Console.WriteLine("a=" + a + "b=" + b);
            //Console.WriteLine("a<b・・・" +c);
            //Console.WriteLine("a>b・・・" + d);
            //Console.WriteLine("a==b・・・" + e);


            //条件演算子
            //string right = "正解", wrong = "不正解";
            //bool value;

            //value = true;
            //string answer = value ? right : wrong;
            //Console.WriteLine(answer);

            //value = false;
            //answer = value ? right : wrong ;
            //Console.WriteLine(answer);


            //論理演算子
            //int a = 3, b = 4;
            //bool x, y;

            //x = (a < 0);
            //y = (b > 0);
            //Console.WriteLine((a == 3) && (b == 3));
            //Console.WriteLine(x || y);


            //演算の優先度
            //Console.WriteLine("2 × 8 - 6 ÷ 2 = " + (2 * 8 - 6 / 2));
            //Console.WriteLine("2　× (8  - 6) ÷ 2 = " + 2 * (8 - 6) /2);
            //Console.WriteLine("1 - 2 + 3 = " + (1 - 2 + 3));
            //Console.WriteLine("1 - (2 + 3 ) = " + (1 - (2 + 3)));


            //コラム checked, unchecked文
            //int a, b;
            //try
            //{
            //    checked
            //    {
            //        a = int.MaxValue;
            //        b = a + 1;
            //        Console.WriteLine(b);
            //    }
            //}

            //catch (OverflowException oe)
            //{
            //    Console.WriteLine(oe.Message);
            //}
        }
    }

    //制御文
    class study3
    {
        static void Main()
        {
            int a = 5;

            if ( a % 2 == 0 )
            {
                Console.WriteLine(a + "は偶数です。");
            } 
            else
            {
                Console.WriteLine(a + "は奇数です。");
            }
        }
    }
}