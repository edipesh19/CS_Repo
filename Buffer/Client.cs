using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DS");

            IBuffer<double> circularBuffer = new CircularBuffer<double>(3);

            ProcessInput(circularBuffer);

            Console.WriteLine("Values in circular buffer are followings");
            foreach (var item in circularBuffer)
            {
                Console.WriteLine(item);
            }

            ProcessBuffer(circularBuffer);
        }

        private static void ProcessBuffer(IBuffer<double> circularBuffer)
        {
            var sum = 0.0;
            while (!circularBuffer.IsEmpty)
            {
                sum += circularBuffer.Read();
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        private static void ProcessInput(IBuffer<double> circularBuffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    circularBuffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}