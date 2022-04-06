using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Logical_Programs_Part1
{
    class StopWatch
    {
       
        static void Main(string[] args)
        {
            DateTime Start = DateTime.Now;
            DateTime End = DateTime.Now ;
            Console.WriteLine("Elapsed time:" + (End - Start));
            Console.ReadLine();

        }
    }
}

