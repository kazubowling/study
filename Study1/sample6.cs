//using System;

//namespace konchu
//{
//    // 昆虫クラス
//    abstract class Insect
//    {
//        public void grow()
//        {
//            tamago();
//            youchu();
//            sanagi();
//            seichu();
//        }
//        protected abstract void tamago();
//        protected abstract void youchu();
//        protected abstract void sanagi();
//        protected abstract void seichu();
//    }

//    // 蝶クラス
//    class Butterfly : Insect
//    {
//        protected override void tamago()
//        {
//            Console.WriteLine("卵です");
//        }
//        protected override void youchu()
//        {
//            Console.WriteLine("イモムシのような幼虫です");
//        }
//        protected override void sanagi()
//        {
//            Console.WriteLine("さなぎになりました");
//        }
//        protected override void seichu()
//        {
//            Console.WriteLine("成虫になりました！");
//        }
//    }

//    // バッタクラス
//    class Grasshopper : Insect
//    {
//        protected override void tamago()
//        {
//            Console.WriteLine("卵です");
//        }
//        protected override void youchu()
//        {
//            Console.WriteLine("幼虫です");
//            Console.WriteLine("脱皮を繰り返します");
//        }
//        protected override void sanagi()
//        {
//            // バッタにさなぎの状態はありません
//        }
//        protected override void seichu()
//        {
//            Console.WriteLine("成虫になりました！");
//        }
//    }

//    // Main() メソッドのクラス
//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("[蝶の生態]");
//            Butterfly butterfly = new Butterfly();
//            butterfly.grow();
//            Console.WriteLine("\n[バッタの生態]");
//            Grasshopper grasshopper = new Grasshopper();
//            grasshopper.grow();
//        }
//    }
//}