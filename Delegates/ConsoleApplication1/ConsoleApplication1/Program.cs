using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // This delegate returns int and takes an int argument.
    delegate int CountIt(int end);

    class VarCapture
    {

        static CountIt Counter()
        {
            int sum = 0;
            // Here, a summation of the count is stored
            // in the captured variable sum.
            CountIt ctObj = delegate(int end)
            {
                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
                return sum;
            };
            return ctObj;
        }
        static void Main(string[] args)
        {
            // Get a counter.
            CountIt count = Counter();
            int result;
            result = count(3);
            Console.WriteLine("Summation of 3 is " + result);
            result = count(5);
            Console.WriteLine("Summation of 5 is " + result);
            Console.WriteLine();
        }
    }
}
