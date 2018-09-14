using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    [TestClass]
    public class TestCalculator
    {
        #region private attributes
        private int testOp1;
        private int testOp2;
        private int testExpectedResult;
        private int testActualResult;
        #endregion private attributes
        [TestMethod]
        public void Test_Add_Success()
        {
            //given
            Calculator testCalculator = new Calculator();
            testOp1 = 2;
            testOp2 = 4;
            testExpectedResult = 6;
            //when
            testActualResult = testCalculator.add(testOp1, testOp2);
            //then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }
    }
}
