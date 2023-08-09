using Microsoft.VisualStudio.TestTools.UnitTesting;
using BreaktheChain;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Solution_ReturnsTheCheapestCostToCutTheChainIntoThreeParts()
        {
            var chain = new[] {5, 2, 4, 6, 3, 7};

            var c = new Solution();
            int result = c.solution(chain);

            Assert.AreEqual(5, result);
        }
    }
}
