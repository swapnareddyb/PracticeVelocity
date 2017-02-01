using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeVelocity.CodingProblem.Services;

namespace PracticeVelocity.CodingProblem.Services.Tests
{
    [TestClass]
    public class MathServiceTest
    {
        private MathService mathService;

        public MathServiceTest()
        {
            mathService = new MathService();
        }

        [TestMethod]
        public void TestIsMultipleWhenDenominatorIs5AndNominatorIs25()
        {
            Assert.IsTrue(mathService.IsMultiple(25, 5));
        }

        [TestMethod]
        public void TestIsMultipleWhenDenominatorIs7AndNominatorIs49()
        {
            Assert.IsTrue(mathService.IsMultiple(49, 7));
        }

        [TestMethod]
        public void TestIsMultipleWhenDenominatorIs7AndNominatorIs50()
        {
            Assert.IsFalse(mathService.IsMultiple(50, 7));
        }
    }
}
