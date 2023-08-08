using Microsoft.VisualStudio.TestTools.UnitTesting;
using FrogPond;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Solution_ReturnsTheCorrectTiming()
        {
            var leafDrop = new[] {1, 3, 1, 4, 2, 5};
            var frogJumps = 3;
            var pondSize = 7;

            var c = new Solution();
            int result = c.solution(leafDrop, pondSize, frogJumps);
            Assert.AreEqual(3, result);
        }
    }
}
