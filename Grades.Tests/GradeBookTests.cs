using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void LetterGrades()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(50);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("C", result.LetterGrade);
        }

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades = new float[3];
            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 5, 1);
            date = date.AddDays(1);
            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void RefferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;
            
            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);


        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

        [TestMethod]
        public void IntVariableHoldAValue()
        {
            int x1 = 4;
            int x2 = x1;
            x1 = 3;
            Assert.AreNotEqual(x1, x2);               
        }

        [TestMethod]
         public void GradeBookVarialeHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's GradeBook";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }

        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }
        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.1);
        }
    }
}
