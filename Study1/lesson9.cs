using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study1
{
    class Connector<T>
    {
        public string connect (T a, T b)
        {
            return a.ToString() + b.ToString();
        }
    }

    class Connector2
    {
        static void Main()
        {
            Connector<int> connector = new Connector<int>();
            Console.WriteLine(connector.connect(46, 49));
        }
    }
}
