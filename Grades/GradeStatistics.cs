using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grades
{
    class GradeStatistics
    {
        public GradeStatistics()
        {
            AverageGrade = 0;
            HighestGrade = 0;
            LowestGrade = double.MaxValue;
        }
        public double AverageGrade;
        public double HighestGrade;
        public double LowestGrade;
    }
}
