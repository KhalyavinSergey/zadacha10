using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 7 / (49 * (Math.Pow(n, 2)) - 7 * n - 12);


            }
            Console.WriteLine("Sum = {0}", s);
            Console.ReadLine();
        }
    }
}
