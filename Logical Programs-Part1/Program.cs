using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Part1
{
    class PerfectNumbers
    {
        static void Main(string[] args)
        {
            int n,sum = 0,r,i;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<n;i++)
            {
                r = n % i;
                if(r==0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of divisors are:{0}", sum);
            if (sum == n)
            {
                Console.WriteLine("given number is perfect number");
            }
            else
            {
                Console.WriteLine("given number is not a perfect number");
            }
            Console.ReadLine();
        }
    }
}
