//using System;
//using System.IO;

//class WriteText
//{
//    static void Main()
//    {
//        FileStream fs;
//        try
//        {
//            fs = new FileStream("file2.txt", FileMode.Create);
//        }
//        catch (IOException)
//        {
//            Console.WriteLine("ファイルを開けません。");
//            return;
//        }

//        StreamWriter w = new StreamWriter(fs);
//        w.Write("ファイルに書き込みました。");

//        w.Close();
//    }
//}