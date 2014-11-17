using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Client
    {
        public static void ConsoleWrite(double data)
        {
            Console.WriteLine(data);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello DS");

            IBuffer<double> buffer = new Buffer<double>();

            // The below line is optional the C# compiler implicitely does that for us
            //Printer<double> ConsoleWrite = new Printer<double>(ConsoleWrite);

            ProcessInput(buffer);

            Console.WriteLine("Values in circular buffer are followings");

            buffer.Dump(ConsoleWrite);
            // In the below code we can iterate over the double type collectio as int
            var asInt = buffer.AsEnumerableOf<double, int>();

            foreach (var item in asInt)
            {
                Console.WriteLine(item);
            }
            ProcessBuffer(buffer);
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();

                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }
    }
}