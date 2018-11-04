using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler5
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 20;

            while (true)
            {
                if (x % 20 == 0 && x % 19 == 0 && x % 18 == 0 && x % 17 == 0 && x % 16 == 0 && x % 15 == 0 && x % 14 == 0 && x % 13 == 0 && x % 12 == 0 && x % 11 == 0)
                {
                    Console.WriteLine(x);
                    Console.Read();
                }
                x++;
            }
        }
    }
}
