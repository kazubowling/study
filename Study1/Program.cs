using System;
using System.Collections.Generic;
using System.Data.Common;
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
        //static void Main()
        //{
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
        //}
    }

    //制御文
    class study3
    {
        //static void Main()
        //{
            //int a = 1999900024;

            //if ( a % 2 == 0 )
            //{
            //    Console.WriteLine(a + "は偶数です。");
            //} 
            //else
            //{
            //    Console.WriteLine(a + "は奇数です。");
            //}

            //int s = 80;

            //Console.WriteLine("あなたの点数は" + s + "点です。");

            //if (s < 70)
            //{
            //    Console.WriteLine("平均点まであと" + (70 - s) + "点");
            //    Console.WriteLine("がんばりましょう！");
            //}
            //else
            //{
            //    Console.WriteLine("よくできました！");
            //}

            //int a = 90;

            //if (a > 80)
            //{
            //    if (a == 100)
            //    {
            //        Console.WriteLine("満点です。");
            //    }
            //    else
            //    {
            //        Console.WriteLine("もう少しです。");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("がんばりましょう。");
            //}


            //int i;

            //for (i = 1; i < 4; i++)
            //{
            //    Console.WriteLine("こんにちは" + i);
            //}


            //int i, j;

            //for (j = 1; j <= 9; j++)
            //{
            //    for(i = 1; i <= 9; i++)
            //    {
            //        Console.WriteLine(j + "×" + i + "=" + j*i);
            //    }
            //}


            //int[] nums = { 1, 2, 3, 4 };

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}


            //while文
            //int i = 0;

            //while (i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //break文
            //int a, b = 2;

            //for (a = 0; a < 5; a++)
            //{
            //    if (b - a <= 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(b + "-" + a + "=" + (b - a));
            //}


            //continue文
            //int a, b = 1;

            //for (a = 0; a < 5; a++)
            //{
            //    if (a + b == 2)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(a + "+" + b + "=" + (a + b));
            //}


            //switch文
            //int a;
            //for (a = 5; a <= 10; a++)
            //{
            //    Console.WriteLine(a + "÷ 3 = " + a / 3);

            //    switch (a % 3)
            //    {
            //        case 1:
            //            Console.WriteLine("：余りは1です。");
            //            break;
            //        case 2:
            //            Console.WriteLine("余りは2です。");
            //            break;
            //        default:
            //            Console.WriteLine("余りは0です。");
            //            break;
            //    }



            //サンプルコード1
            //int[] myPos = { 20, 30 };
            //int[,] enemyPos =
            //{
            //    {2, 4},
            //    {10, 6},
            //    {25, 20}
            //};

            //int i;
            //int dx, dy;
            //double d;
            //double r = 15; 
            //for (i = 0; i < 3; i++)
            //{
            //    dx = myPos[0] - enemyPos[i, 0];
            //    dy = myPos[1] - enemyPos[i, 1];
            //    d = (double)(dx * dx + dy * dy);
            //    if (d > r * r)
            //    {
            //        Console.WriteLine("敵" + i + "は射程圏外です");
            //    }
            //    else
            //    {
            //        Console.WriteLine("敵" + i + "は射程圏内です");
            //    }
            //}

            //サンプルコード2

            //string[] names =
            //{
            //    "向井　康二　", "目黒　蓮　　", "阿部　亮平　", "渡辺　翔太　", "深澤　辰哉　", "佐久間　大介", "宮舘　涼太　", "ラウール　　", "岩本　照　　"
            //};

            //int[] scores =
            //{
            //    48, 75, 62, 90, 84, 28, 35, 50, 89
            //};

            //int i, j;
            //string s;

            //for (i = 0; i < 9;  i++)
            //{
            //    Console.Write(names[i] + " " + scores[i] + " ");
            //    for (j = 0; j < scores[i] / 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    if (scores[i] < 50)
            //    {
            //        s = "もう少し！";
            //    }
            //    else if (scores[i] < 70)
            //    {
            //        s = "まあまあです";
            //    }
            //    else if (scores[i] < 90)
            //    {
            //        s = "よくできました";
            //    } 
            //    else
            //    {
            //        s = "たいへんよくできました！";
            //    }

            //    Console.WriteLine(" " + s);
            //}
        //}
    }
    //第4章
    //フィールド
    class field
    {
        public int month;
        public int day;
        public string sky;
    }

    class weather
    {
        //static void Main()
        //{
        //    field today = new field();
        //    today.month = 11;
        //    today.day = 1;
        //    today.sky = "晴れ";
        //    Console.WriteLine(today.month + "月" + today.day + "日" + today.sky);
        //}
    }

    namespace overload
    {
        class Cat
        {
            string name;
            string place;
            int age;

            public void setData(string n, string p, int a)
            {
                name = n;
                place = p;
                age = a;
            }

            public void print()
            {
                Console.WriteLine(place + ":" + name + " " + age + "歳");
            }

            public void print(string p, int a)
            {
                place = p;
                Console.WriteLine(place + ":ねこは" + a + "匹です。");
            }

            public void print(string variety)
            {
                Console.WriteLine(place + ":" + name + " " + age + "歳" + variety);
            }
        }

        class Pet
        {
            static void Main1()
            {
                Cat cat1 = new Cat();
                Cat cat2 = new Cat();
                Cat cat3 = new Cat();

                cat1.setData("ロビン", "う　ち", 10);
                cat2.setData("ちび", "となり", 14);
                cat1.print("雑種");
                cat2.print();
                cat3.print("う　ら", 0);
            }
        }
    }

    namespace constructor
    {
        class Book
        {
            public int price;
            public int num = 0;
            public string title;

            public Book(string t, int p)
            {
                title = t; 
                price = p;
            }

            public void print()
            {
                Console.WriteLine("タイトル：" + title);
                Console.WriteLine("定　　価：" + price);
                Console.WriteLine("注文部数：" + num);
                Console.WriteLine("合計金額：" + price * num);
            }
        }

        class Books
        {
            static void Main()
            {
                Book book = new Book("Cの絵本", 1380);
                book.num = 10;
                book.print();
            }
        }
    }

    namespace properties
    {
        class Aroma
        {
            public double drop; //値を格納するフィールド
            public double itteki
            {
                get
                {
                    return drop;
                }

                set
                {
                    drop = value;
                }
            }
        }

        class AromaSample
        {
            public static void Main2()
            {
                Aroma aroma = new Aroma();
                aroma.itteki = 0.05;
                Console.WriteLine("1滴あたり " + aroma.itteki + "mlです。");
            }
        }
    }
    
}  