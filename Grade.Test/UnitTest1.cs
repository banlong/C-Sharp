using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;

namespace Grade.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateHighestGrade()
        {
            GradeBooks book = new GradeBooks();
            book.AddGrade(50f);
            book.AddGrade(90f);
            GradeStatistic stat = book.ComputeStatistic();
            Assert.AreEqual(stat.HighestGrade, 90f);
            
        }
    }
}
