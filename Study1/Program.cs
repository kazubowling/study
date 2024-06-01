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
    //class field
    //{
    //    public int month;
    //    public int day;
    //    public string sky;
    //}

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

    //namespace overload
    //{
    //    class Cat
    //    {
    //        string name;
    //        string place;
    //        int age;

    //        public void setData(string n, string p, int a)
    //        {
    //            name = n;
    //            place = p;
    //            age = a;
    //        }

    //        public void print()
    //        {
    //            Console.WriteLine(place + ":" + name + " " + age + "歳");
    //        }

    //        public void print(string p, int a)
    //        {
    //            place = p;
    //            Console.WriteLine(place + ":ねこは" + a + "匹です。");
    //        }

    //        public void print(string variety)
    //        {
    //            Console.WriteLine(place + ":" + name + " " + age + "歳" + variety);
    //        }
    //    }

    //    class Pet
    //    {
    //        static void Main1()
    //        {
    //            Cat cat1 = new Cat();
    //            Cat cat2 = new Cat();
    //            Cat cat3 = new Cat();

    //            cat1.setData("ロビン", "う　ち", 10);
    //            cat2.setData("ちび", "となり", 14);
    //            cat1.print("雑種");
    //            cat2.print();
    //            cat3.print("う　ら", 0);
    //        }
    //    }
    //}

    //namespace constructor
    //{
    //    class Book
    //    {
    //        public int price;
    //        public int num = 0;
    //        public string title;

    //        public Book(string t, int p)
    //        {
    //            title = t; 
    //            price = p;
    //        }

    //        public void print()
    //        {
    //            Console.WriteLine("タイトル：" + title);
    //            Console.WriteLine("定　　価：" + price);
    //            Console.WriteLine("注文部数：" + num);
    //            Console.WriteLine("合計金額：" + price * num);
    //        }
    //    }

    //    class Books
    //    {
    //        static void Main()
    //        {
    //            Book book = new Book("Cの絵本", 1380);
    //            book.num = 10;
    //            book.print();
    //        }
    //    }
    //}

    //namespace properties
    //{
    //    class Aroma
    //    {
    //        public double drop; //値を格納するフィールド
    //        public double itteki
    //        {
    //            get
    //            {
    //                return drop;
    //            }

    //            set
    //            {
    //                drop = value;
    //            }
    //        }
    //    }

    //    class AromaSample
    //    {
    //        public static void Main()
    //        {
    //            Aroma aroma = new Aroma();
    //            aroma.itteki = 0.05;
    //            Console.WriteLine("1滴あたり " + aroma.itteki + "mlです。");
    //        }
    //    }
    //}

    //namespace indexer
    //{
    //    class Kazu1
    //    {
    //        int[] suji = new int[4];
    //        public int this[int i]
    //        {
    //            get
    //            {
    //                return suji[i];
    //            }

    //            set
    //            {
    //                suji[i] = value;
    //            }
    //        }
    //    }

    //    class Kazu2
    //    {
    //        static void Main()
    //        {
    //            Kazu1 kz = new Kazu1();
    //            kz[0] = 1;
    //            kz[1] = 2;
    //            kz[2] = 3;
    //            kz[3] = 4;
    //            for (int i = 0; i <= 3; i++)
    //            {
    //                Console.WriteLine(kz[i]);
    //            }
    //        }
    //    }
    //}

    //namespace cmdline
    //{
    //    class Cmdline
    //    {
    //        static void Main(string[] args)
    //        {
    //            int i;

    //            if (args.Length == 0)
    //            {
    //                Console.WriteLine("コマンド引数はありません");
    //            } 
    //            else
    //            {
    //                for (i = 0; i < args.Length; i++)
    //                {
    //                    Console.WriteLine((i+1) + "：" + args[i]);
    //                }
    //            }
    //        }
    //    }
    //}

    // namespace sample2
    // {
    //     class Engine
    //     {
    //         string name;
    //         int size;

    //         public Engine(string n, int s)
    //         { //コンストラクタ
    //             name = n;
    //             size = s;
    //         }

    //         public int Size
    //         {
    //             get
    //             {
    //                 return size;
    //             }

    //         }
    //     }

    //     class Car
    //     {
    //         string name;
    //         Engine engine;

    //         public Car(string n, Engine e)
    //         { //コンストラクタ
    //             name = n;
    //             engine = e;
    //         }

    //         public void printInfo()
    //         {
    //             Console.WriteLine(name + "(" + engine.Size + "cc)");
    //         }
    //     }

    //     //Main()メソッドのクラス
    //     class Program
    //     {
    //         static void Main()
    //         {
    //             Engine blf = new Engine("BLF", 1597);
    //             Engine bvy = new Engine("BVY", 1984);
    //             Engine blg = new Engine("BLG", 1389);

    //             Car[] cars = new Car[4]; //Carクラスの配列を用意
    //             cars[0] = new Car("GOLF E", blf);
    //             cars[1] = new Car("GOLF GLI", bvy);
    //             cars[2] = new Car("GOLF GT TSI", blg);
    //             cars[3] = new Car("GOLF Octave", blf);

    //             foreach (Car car in cars)
    //             {
    //                 car.printInfo();
    //             }
    //         }
    //     }
    // }

    //第5章クラスの継承
    //namespace inheritance
    //{
    //    class book
    //    {
    //        public string title;
    //        public string genre;

    //        public void printBook()
    //        {
    //            Console.WriteLine("タイトル：" + title);
    //            Console.WriteLine("ジャンル：" + genre);
    //        }
    //    }

    //    class Novel : book
    //    {
    //        public string writer;
    //        public void printNov()
    //        {
    //            printBook();
    //            Console.WriteLine("著　　者：" + writer);
    //        }
    //    }

    //    class Magazine : book
    //    {
    //        public int day;
    //        public void printMag()
    //        {
    //            printBook();
    //            Console.WriteLine("発売日：" + day + "日");
    //        }
    //    }

    //    class Bookshelf
    //    {
    //        public static void Main()
    //        {
    //            Novel nov = new Novel();
    //                nov.title = " しおりの秘境発見";
    //                nov.genre = " ファンタジー";
    //                nov.writer = " アンク";                

    //            Magazine mag = new Magazine();
    //                mag.title = "月刊C#の絵本";
    //                mag.genre = "コンピュータ";
    //                mag.day = 20;

    //            nov.printNov();
    //            Console.WriteLine();
    //            mag.printMag();
    //        }
    //    }
    //}

    //namespace modifier
    //{
    //    class Purse
    //    {
    //        public static int money = 0;

    //        public void printMoney(int In, int Out)
    //        {
    //            money = money + In - Out;
    //            if(money < 0)
    //            {
    //                Console.WriteLine((-1 * money) + "円足りません。");
    //            } 
    //            else
    //            {
    //                Console.WriteLine("残金は" + money + "円です。");
    //            }
    //        }
    //    }

    //    class shopping
    //    {
    //        public static void Main()
    //        {
    //            Purse store1 = new Purse();
    //            Purse store2 = new Purse();
    //            store1.printMoney(1000, 100);
    //            store2.printMoney(0, 250);
    //            store1.printMoney(0, 800);
    //        }
    //    }
    //}

    //namespace constructor2
    //{
    //    class Calc1
    //    {
    //        public int x;
    //        public Calc1(int a, int b) 
    //        {
    //            x = a + b;
    //        }
    //    }

    //    class Calc2 : Calc1
    //    {
    //        public Calc2(int c, int d) : base(c, d) { }
    //    }

    //    class Calc3
    //    {
    //        public static void Main()
    //        {
    //            Calc2 calc2 = new Calc2(1, 2);
    //            Console.WriteLine(calc2.x);
    //        }
    //    }
    //}

    //namespace hiding
    //{
    //    class A
    //    {
    //        public int a = 3;
    //    }

    //    class B : A
    //    {
    //        new public int a = 100;
    //    }

    //    class C
    //    {
    //        public static void Main()
    //        {
    //            B b = new B();
    //            Console.WriteLine(b.a);
    //        }
    //    }
    //}

    //namespace hiding2
    //{
    //    class A
    //    {
    //        public int a = 3;
    //    }

    //    class B : A
    //    {
    //        new public int a = 100;
    //        public void print()
    //        {
    //            Console.WriteLine("Aクラスのaは" + base.a);
    //        }
    //    }

    //    class C
    //    {
    //        public static void Main()
    //        {
    //            B b = new B();
    //            b.print();
    //        }
    //    }
    //}

    //namespace over_ride
    //{
    //    class Greeting
    //    {
    //        public virtual void bye()
    //        {
    //            Console.WriteLine("good bye");
    //        }
    //    }

    //    class Aisatsu : Greeting
    //    {
    //        public override void bye()
    //        {
    //            Console.WriteLine("さようなら");
    //        }

    //        public void cheer()
    //        {
    //            Console.WriteLine("元気でね！");
    //        }
    //    }

    //    class Owakare
    //    {
    //        public static void Main()
    //        {
    //            Aisatsu aisatsu = new Aisatsu();
    //            aisatsu.bye();
    //            aisatsu.cheer();
    //        }
    //    }
    //}

    //namespace indexeroverride
    //{
    //    class Word1
    //    {
    //        public char[] word = new char[7];

    //        public virtual char this[int i]
    //        {
    //            get
    //            {
    //                return word[i];
    //            }

    //            set
    //            {
    //                if(i >= 0)
    //                {
    //                    word[i] = value;
    //                }
    //            }
    //        }
    //    }

    //    class Word2 : Word1
    //    {
    //        public override char this[int i]
    //        {
    //            get
    //            {
    //                return word[i];
    //            }

    //            set
    //            {
    //                if (i >= 3)
    //                {
    //                    word[i] = value;
    //                }
    //            }
    //        }
    //    }

    //    class WordSample
    //    {
    //        static void Main()
    //        {
    //            Word2 word2 = new Word2();

    //            word2[0] = 'k';
    //            word2[1] = 'e';
    //            word2[2] = 'y';
    //            word2[3] = 'w';
    //            word2[4] = 'o';
    //            word2[5] = 'r';
    //            word2[6] = 'd';

    //            int i;
    //            for(i = 0; i <= 6; i++)
    //            {
    //                Console.Write(word2[i]);
    //            }
    //            Console.WriteLine("\n");
    //        }
    //    }
    //}


    //namespace sample5
    //{
    //    //定規クラス(基本クラス)
    //    class Ruler
    //    {
    //        protected string material = "プラスティック"; //材質

    //        protected string getInfo()
    //        {
    //            return "材料は" + material + "です。";
    //        }
    //    }

    //    //三角定規クラス
    //    class TriangleRuler : Ruler
    //    {
    //        double[] angles = new double[3]; //三角
    //        double short_side; //短い辺

    //        public TriangleRuler(double a1, double a2, double s)
    //        {
    //            angles[0] = a1;
    //            angles[1] = a2;
    //            angles[2] = 180.0 - a1 - a2;
    //            short_side = s;
    //        }

    //        public TriangleRuler(double a1, double a2, double s, string m)
    //        {
    //            angles[0] = a1;
    //            angles[1] = a2;
    //            angles[2] = 180.0 - a1 - a2;
    //            short_side = s;
    //            material = m;
    //        }

    //        public new string getInfo()
    //        {
    //            string s;
    //            s = "この三角定規は、３頂点の角度がそれぞれ" + angles[0] + "°," + angles[1] + "°," + angles[2] + "°で、一番短い辺の長さは" + short_side + "mmです。";
    //            s += base.getInfo();
    //            return s;
    //        }
    //    }
    //    //直線定規クラス
    //    class LineRuler : Ruler
    //    {
    //        int length; //測れる長さ

    //        public LineRuler(int l, string m)
    //        {
    //            length = l;
    //            material = m;
    //        }

    //        public new string getInfo()
    //        {
    //            string s;
    //            s = "この直線定規は" + length / 10.0 + "cmまで測れます。";
    //            s += base.getInfo();
    //            return s;
    //        }
    //    }

    //    //Main()メソッドのクラス
    //    class Program
    //    {
    //        static void Main()
    //        {
    //            TriangleRuler tr1 = new TriangleRuler(45.0, 45.0, 150.0);
    //            TriangleRuler tr2 = new TriangleRuler(45.0, 45.0, 200.0, "ステレンス");
    //            TriangleRuler tr3 = new TriangleRuler(30.0, 60.0, 100.0);
    //            LineRuler lr1 = new LineRuler(300, "竹");
    //            Console.WriteLine(tr1.getInfo());
    //            Console.WriteLine(tr2.getInfo());
    //            Console.WriteLine(tr3.getInfo());
    //            Console.WriteLine(lr1.getInfo());
    //        }
    //    }
    //}

    namespace Section_6
    {
        //    abstract class CalcA
        //    {
        //        public int a;
        //        public int b;
        //        public abstract void answer();

        //        public void setData(int m, int n)
        //        {
        //            a = m;
        //            b = n;
        //        }
        //    }

        //    class Plus : CalcA
        //    {
        //        public override void answer()
        //        {
        //            Console.WriteLine(a + "+" + b + "=" + (a + b));
        //        }
        //    }

        //    class AbstSample
        //    {
        //        static void Main()
        //        {
        //            Plus plus = new Plus();
        //            plus.setData(27, 32);
        //            plus.answer();
        //        }
        //    }
        //}

        //interface A
        //{
        //    void say();
        //    int prop
        //    {
        //        get;
        //        set;
        //    }
        //}

        //class X : A
        //{
        //    public int b;
        //    public void say()
        //    {
        //        Console.WriteLine("Hello");
        //    }
        //    public int prop
        //    {
        //        get
        //        {
        //            return b;
        //        }
        //        set
        //        {
        //            b = value;
        //        }
        //    }
        //}

        //class IFSample
        //{
        //    static void Main()
        //    {
        //        X x = new X();
        //        x.say();
        //        x.prop = 52;
        //        Console.WriteLine(x.prop);
        //    }
        //}

        //interface Greet
        //{
        //    void greet();
        //}
        
        //interface  Bye : Greet 
        //{
        //    void bye();
        //}
        
        //class Greeting : Bye
        //{
        //    public void greet()
        //    {
        //        Console.WriteLine("こんにちは！");
        //    }
        //    public void bye()
        //    {
        //        Console.WriteLine("さよなら");
        //    }
        //}

        //class Meet
        //{
        //    static void Main()
        //    {
        //        Greeting greeting = new Greeting();
        //        greeting.greet();
        //        greeting.bye();
        //    }
        //}

        //class A
        //{
        //    public void m()
        //    {
        //        Console.WriteLine("Aクラスのメソッド");
        //    }
        //}

        //class B : A
        //{
        //    public new void m()
        //    {
        //        Console.WriteLine("Bクラスのメソッド");
        //    }
        //}

        //class NewSample
        //{
        //    static void Main()
        //    {
        //        A a = new A();
        //        B b = new B();
        //        A ab = new B();

        //        a.m();
        //        b.m();
        //        ab.m();
        //    }
        //}

        //class ObjectSample
        //{
        //    static void Main()
        //    {
        //        float b = 3.14F;
        //        object ob;
        //        float c;

        //        Console.WriteLine(b);
        //        ob = b;
        //        c = (float)ob;
        //        Console.WriteLine(c);
        //    }
        //}

        namespace Tokyo
        {
            class TokyoTower
            {
                public void print()
                {
                    Console.WriteLine("東京タワー");
                }
            }
            namespace Toshima
            {
                class Sunshine
                {
                    public void print()
                    {
                        Console.WriteLine("サンシャイン60");
                    }
                }
            }
        }

        class TokyoSpots
        {
            static void Main()
            {
                Tokyo.TokyoTower tower = new Tokyo.TokyoTower();
                Tokyo.Toshima.Sunshine sunshine = new Tokyo.Toshima.Sunshine();
                tower.print();
                sunshine.print();
            }
        }
    }
}  