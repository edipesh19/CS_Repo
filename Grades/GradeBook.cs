using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        List<double> grades;
        public string Name;

        public GradeBook()
        {
            grades = new List<double>();
        }
        public void AddGrade(double p)
        {
            grades.Add(p);
        }

        public GradeStatistics ComputeStatictics()
        {
            GradeStatistics stats = new GradeStatistics();
            double sum = 0.0;

            foreach(double grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade  = Math.Min(grade, stats.HighestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum/grades.Count;

            return stats;
        }
    }
}
