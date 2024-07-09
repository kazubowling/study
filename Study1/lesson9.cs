using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    /// <summary>
    /// ジェネリッククラス
    /// </summary>
    //class Connector<T>
    //{
    //    public string connect (T a, T b)
    //    {
    //        return a.ToString() + b.ToString();
    //    }
    //}

    //class Connector2
    //{
    //    static void Main()
    //    {
    //        Connector<int> connector = new Connector<int>();
    //        Console.WriteLine(connector.connect(46, 49));
    //    }
    //}

    /// <summary>
    /// デリゲート
    /// </summary>
    //delegate int DelegMsgs();

    //class DelegSample
    //{
    //    static int print1()
    //    {
    //        Console.WriteLine("print1");
    //        return 1;
    //    }
    //    static int print2()
    //    {
    //        Console.WriteLine("print2");
    //        return 2;
    //    }
    //    static void Main()
    //    {
    //        DelegMsgs deleg;
    //        deleg = new DelegMsgs(print1);
    //        deleg += new DelegMsgs(print2);
    //        int n = deleg();
    //        Console.WriteLine(n);
    //    }
    //}

    /// <summary>
    /// イベント
    /// </summary>
    //// デリゲートの準備
    //delegate void DelegEvent();
    //class EventClass
    //{
    //    // イベントの宣言
    //    public event DelegEvent delegevent;

    //    public void start()
    //    {
    //        // デリゲートが登録されているかチェックする
    //        if (delegevent != null)
    //        {
    //            System.Threading.Thread.Sleep(3000);
    //            delegevent();
    //        }
    //    }
    //}
    //class DelegSamle
    //{
    //    static void handler()
    //    {
    //        Console.WriteLine("ハンドラが呼び出されました");
    //    }
    //    static void Main()
    //    {
    //        EventClass e = new EventClass();
    //        // イベントの登録
    //        e.delegevent += new DelegEvent(handler);
    //        e.start();
    //    }
    //}

    /// <summary>
    /// LINQ
    /// </summary>
    //class MainClss
    //{
    //    static void Main(string[] args)
    //    {
    //        var books = new[]
    //        {
    //            new { title = "しおりの料理", price = 800 },
    //            new { title = "しおりのC#入門", price = 1200 },
    //            new { title = "しおりの航海記", price = 1500 }
    //        };

    //        var mybooks = books.Where(x => x.price > 1000).Select(x => x.title);

    //        foreach (var booktitle in mybooks)
    //        {
    //            Console.WriteLine(booktitle);
    //        }
    //    }
    //}


}
