using System;
using System.IO;

namespace timecard
{
    class Program
    {
        const string fn = "times.txt";

        static bool appendTime(bool goWork)
        {
            DateTime dt = DateTime.Now;
            string mode = goWork ? "出勤" : "退勤";
            string s = mode + " "
                +dt.Year + "/" + dt.Month + "/" + dt.Day + " " + dt.Hour + ":" + dt.Minute;
            try
            {
                FileStream fs = new FileStream(fn, FileMode.Append);
                StreamWriter w = new StreamWriter(fs);
                // 時刻データをファイルに書き込む
                w.Write(s);
                w.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("書き込みに失敗しました");
                return false;
            }

            Console.WriteLine(s);
            return true;
        }

        // 一覧を作成し、表示するためのメソッド
        static void listTime()
        {
            string s;
            try
            {
                FileStream fs = new FileStream(fn, FileMode.Open);
                StreamReader r = new StreamReader(fs);
                // 時刻データを記録したファイルを読み込む
                s = r.ReadLine();
                while (s != null)
                {
                    Console.WriteLine(s);
                    // 次回分の読み込み
                    s = r.ReadLine();
                }
                r.Close();
            }
            catch (IOException)
            {
                Console.WriteLine("読み込みませんでした。");
                return;
            }
        }

        static void usage()
        {
            Console.WriteLine("コマンドを入力してください");
            Console.WriteLine("i:出勤　o:退勤 l:一覧　q:終了");
        }

        static void Main()
        {
            usage();
            while (true)
            {
                // プロンプトの「>」を表示
                Console.Write("> ");
                string cmd = Console.ReadLine();
                if (cmd == "i")
                {
                    appendTime(true);
                }
                else if (cmd == "o")
                {
                    appendTime(false);
                }
                else if (cmd == "l")
                {
                    listTime();
                }
                else if (cmd == "q")
                {
                    break;
                }
                else
                {
                    usage();
                }
            }
        }
    }
}