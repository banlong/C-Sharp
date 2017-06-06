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
            GradeBooks book = new GradeBooks();
            book.AddGrade(91);
            book.AddGrade((float)89.5);

            GradeStatistic stat = book.ComputeStatistic();
            Console.WriteLine("Average Grade:{0}", stat.AverageGrade);
            Console.WriteLine("Lowest Grade:{0}", stat.LowestGrade);
            Console.WriteLine("Highest Grade:{0}", stat.HighestGrade);

            ParameterName(First: 15);

            Console.ReadKey();
        }

        static void ParameterName(int First, string Second="") {
            Console.WriteLine("First: {0} , Second: {1}", First, Second);
        }
    }
}
