using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
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

    // デリゲートの準備
    delegate void DelegEvent();
    class EventClass
    {
        // イベントの宣言
        public event DelegEvent delegevent;

        public void start()
        {
            // デリゲートが登録されているかチェックする
            if (delegevent != null)
            {
                System.Threading.Thread.Sleep(3000);
                delegevent();
            }
        }
    }
    class DelegSamle
    {
        static void handler()
        {
            Console.WriteLine("ハンドラが呼び出されました");
        }
        static void Main()
        {
            EventClass e = new EventClass();
            // イベントの登録
            e.delegevent += new DelegEvent(handler);
            e.start();
        }
    }
}
