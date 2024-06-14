//using System;

//class KazuAte
//{
//    static void Main(string[] args)
//    {
//        Random rnd = new Random();
        
//        // 正解
//        int a = rnd.Next(1, 31);

//        Console.WriteLine("1から30までの値を入力してください。");
//        while (true)
//        {
//            // 1行入力
//            string s = Console.ReadLine();

//            // 何も入力されずにEnterが押されたら終了
//            if (s == " ")
//            {
//                Console.WriteLine("終了します。");
//                break;
//            }

//            // 回答
//            int n = 0;
//            try
//            {
//                // 入力文字列を数字に変換
//                n = int.Parse(s);
//            }
//            catch (FormatException e)
//            {
//                Console.WriteLine(e.Message);
//                Console.WriteLine("1から30までの値を入力してください。");
//                continue;
//            }

//            // 判定
//            if (n == a)
//            {
//                Console.WriteLine("あたりです！");
//                break;
//            }
//            else if (n > a)
//            {
//                Console.WriteLine("大きすぎます。");
//            } 
//            else if (n < a)
//            {
//                Console.WriteLine("小さすぎます。");
//            }
//        }
//    }
//}