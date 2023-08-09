using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackMachineEmulator;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Solution_CanParseReversePolishNotation()
        {
            var str = "13+62*7+*";
            var c = new Solution();

            int result = c.solution(str);

            Assert.AreEqual(76, result);
        }
    }
}
