using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBooks
    {
        List<float> grades;

        //Constructor
        public GradeBooks() {
            grades = new List<float>();
        }

        //public method
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        //public method
        public void PrintGrades() {
            foreach (float grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private void PrivateMethod() {
              //cannot access from outside the class
        }

        public GradeStatistic ComputeStatistic() {
            GradeStatistic stat = new GradeStatistic();
            float sum = 0f;
            foreach (float grade in  grades) {
                stat.HighestGrade = Math.Max(grade, stat.HighestGrade);
                stat.LowestGrade = Math.Min(grade, stat.LowestGrade);
                
                sum += grade;

            }
            stat.AverageGrade = sum / grades.Count;
            return stat;
        } 
    }
}
