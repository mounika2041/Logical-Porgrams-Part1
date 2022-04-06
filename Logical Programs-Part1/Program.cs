using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Part1
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int n, k= 0,r,i;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                r = n % i;
                if (r == 0)
                {
                    k++;
                }
            }
            if (k <= 2)
            {
                Console.WriteLine("given number is prime number");
            }
            else
            {
                Console.WriteLine("given number is not a prime number");
            }
            Console.ReadLine();
        }
    }
}
