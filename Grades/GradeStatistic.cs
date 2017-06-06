using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistic
    {
        public float HighestGrade;
        public float AverageGrade;
        public float LowestGrade;
        
        public GradeStatistic() {
            HighestGrade = 0;
            AverageGrade = 0f;
            LowestGrade = float.MaxValue;
        }

    }
}
