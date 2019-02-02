using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook 
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");

            float Lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                Lowest = Math.Min(Lowest, grade);
            }
            grades.Remove(Lowest);      // be careful - especially if there is only one or no grades 
            return base.ComputeStatistics();
        }
    }
}
