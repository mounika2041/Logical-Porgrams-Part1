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
            int n, f1=0, f2=1, f3;
            Console.WriteLine("enter the number of element:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The fibonacci Series is:");
            Console.WriteLine(f1 + ""+ f2+"");
            f3 = f1 + f2;
            while(f3<=n)
            {
                Console.WriteLine(f3 + "");
                f1 = f2;
                f2 = f3;
                f3 = f1 + f2;
            }
            Console.ReadLine();
        }
    }
}
