using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_Part1
{
    class CouponNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter how many distinct number of coupons needed :");
            int num = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            List<int> list = new List<int>();
            int i = 0, count = 0;
            while (i < num)
            {
                int res = random.Next(1, 101);
                count++;
                if (!list.Contains(res))
                {
                    list.Add(res);
                    i++;
                    Console.WriteLine(res);
                }
            }
            Console.WriteLine("{0} times used random class to get {1} distinct coupon numbers", count, num);
            Console.ReadLine();
        }
    }
}

