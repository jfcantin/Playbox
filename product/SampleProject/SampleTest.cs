using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MbUnit.Framework;

namespace SampleProject
{
    [TestFixture]
    public class SampleTest
    {
        [RowTest]
        [Row(1,1,2)]
        [Row(1,2,3)]
        [Row(1,3,4)]
        [Row(2,2,4)]
        public void AddsTwoNumberTogether(int firstNumber, int secondNumber, int expectedResult)
        {
            Calculator calc = new Calculator();
            var result = calc.Add(firstNumber, secondNumber);
            Assert.AreEqual(expectedResult, result);

        }
    }
}
