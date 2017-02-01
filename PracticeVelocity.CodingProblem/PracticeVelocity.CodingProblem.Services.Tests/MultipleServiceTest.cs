using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeVelocity.CodingProblem.Services;

namespace PracticeVelocity.CodingProblem.Services.Tests
{
    [TestClass]
    public class MultipleServiceTest
    {
        private MultiplesService multipleService;

        public MultipleServiceTest()
        {
            multipleService = new MultiplesService();
        }

        [TestMethod]
        public void TestIsMultipleWhenDenominatorIs5AndNominatorIs25()
        {
            Assert.IsTrue(multipleService.IsMultiple(25, 5));
        }

        [TestMethod]
        public void TestIsMultipleWhenDenominatorIs7AndNominatorIs49()
        {
            Assert.IsTrue(multipleService.IsMultiple(49, 7));
        }

        [TestMethod]
        public void TestIsMultipleWhenDenominatorIs7AndNominatorIs50()
        {
            Assert.IsFalse(multipleService.IsMultiple(50, 7));
        }
    }
}
