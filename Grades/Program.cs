using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 =g1;

            g1 = new GradeBook();
            g1.Name = "Dipesh";
            Console.WriteLine(g2.Name);

            //GradeBook book = new GradeBook(); ;
            //book.AddGrade(91);
            //book.AddGrade(89.5);
            //book.AddGrade(75.5);

            //GradeStatistics statistics = book.ComputeStatictics();
            //Console.WriteLine(statistics.HighestGrade);
            //Console.WriteLine(statistics.LowestGrade);
            //Console.WriteLine(statistics.AverageGrade);

        }
    }
}
