using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastingOrderOfOps
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0 + 1 + 1.0f;
            int x = (int)(7 + 3.0 / 4.0 * 2);
            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine((1 + 1) / 2 * 3);
        }
    }
}
