using System;
using F = Fishing;

namespace Fishing
{
    class Fish
    {
        int num;
        string name;
        public Fish(string m, int n)
        {
            name = m;
            num = n;
        }
        public void print()
        {
            Console.WriteLine(name + "の釣れた数" + num + "匹");
        }
    }
}

class FishingSample
{
    static void Main()
    {
        F.Fish iwashi = new F.Fish("イワシ", 12);
        F.Fish fugu = new F.Fish("フグ", 5);
        iwashi.print();
        fugu.print();
    } 
}
