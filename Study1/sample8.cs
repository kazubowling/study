using System;
using System.IO;

namespace ShuffleQuiz
{
    class program
    {
        // シャッフルされた文字列の取得
        static string shuffle(string s)
        {
            int len = s.Length; // 文字列の長さ＝文字配列の長さとなる

            // 文字列から文字配列へ変換
            char[] cs = s.ToCharArray();

            // 文字の長さの回数シャッフルする
            Random rnd = new Random();
            int i;
            for (i = 0; i < len; i++)
            {
                // 入れ替え位置の決定
                int n1 = rnd.Next(len); // 入れ替え位置(1)
                int n2 = n1; // 入れ替え位置(2)
                while (n2 == n1) // n1とn2が同じでは入れ替える意味がない
                {
                    n2 = rnd.Next(len);
                }

                // 文字入れ替え
                char tmp = cs[n1]; // tmpは一時退避用の変数
                cs[n1] = cs[n2];
                cs[n2] = tmp;
            }

            // 文字配列から文字列への変換
            string t = new string(cs);
            return t;
        }

        static void Main()
        {
            Console.WriteLine("** シャッフルクイズ **");
            FileStream fs;
            StreamReader r;
            try
            {
                // ファイルのオープン
                // System.Text.Encoding.DefaultはシステムデフォルトのShift-JIS形式のファイルを
                // 読み込むという意味
                fs = new FileStream("q.txt", FileMode.Open);
                r = new StreamReader(fs, System.Text.Encoding.Default);
            }
            catch (IOException e)
            {
                Console.WriteLine("問題ファイルを読み込めませんでした");
                Console.WriteLine(e.Message);
                return;
            }

            string s, t, a; // s: 正解文字列 t:問題の文字列 a:ユーザの回答
            int n = 1; // 問題番号
            s = r.ReadLine();
            while (s != null)
            {
                t = shuffle(s);
                Console.WriteLine("Q{0} 「{1}」を並べ替えると何になる？", n, t);
                int miss = 0;
                while (miss < 3)
                {
                    a = Console.ReadLine();
                    if (a == s)
                    {
                        break;
                    }
                    Console.WriteLine("違います");
                    miss++;
                    if (miss == 2)
                    {
                        Console.WriteLine("ヒント：最初の３文字は {0} です", s.Substring(0, 3));
                    }                    
                }

                if (miss >= 3)
                {
                    Console.WriteLine("正解は「" + s + "」でした\n");
                }
                else
                {
                    Console.WriteLine("正解です！");
                }

                s = r.ReadLine(); // 次の問題の正解文字列の読み込み
                n++;
            }
            Console.WriteLine("問題は以上です");
            r.Close();
        }
    }
}