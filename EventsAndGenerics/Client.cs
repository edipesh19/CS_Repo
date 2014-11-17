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

            var circularBuffer = new CircularBuffer<double>(3);
            circularBuffer.ItemDiscarded += ItemDiscarded;

            ProcessInput(circularBuffer);

            Console.WriteLine("Values in circular buffer are followings");
            foreach (var item in circularBuffer)
            {
                Console.WriteLine(item);
            }

            ProcessBuffer(circularBuffer);
        }

        private static void ItemDiscarded(object sender, ItemDiscardedEventArgs<double> e)
        {
            Console.WriteLine("Buffer full. Discarding {0} new item is {1}", e.OldItem, e.NewItem);
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