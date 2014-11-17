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

            // Action will not return any value
            //Action<double> print = ConsoleWrite;
            //Action<double> print = delegate(double d)
            //{
            //    Console.WriteLine(d);
            //};

            Action<bool> print = d => Console.WriteLine(d); // Action will not return any value
            Func<double, double> square = d => d * d;       // The last type is the return type
            Func<double, double, double> add = (x, y) => x + y;
            Predicate<double> isLessThanTen = d => d < 10;  // Always return boolean

            print(isLessThanTen(square(add(3,4))));






            ProcessInput(buffer);

            Console.WriteLine("Values in buffer are followings");

            //buffer.Dump(print);
            buffer.Dump(d => Console.WriteLine(d));
            // In the below code we can iterate over the double type collectio as int

            Converter<double, DateTime> convert = d => new DateTime(2010, 1, 1).AddDays(d);
            var asDateTime = buffer.Map(convert);

            foreach (var item in asDateTime)
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