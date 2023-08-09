using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Solution()
        {
            var n = 15;

            var sln = new Solution();
            var result = sln.solution(n);

            Assert.AreEqual("1", result[0]);
            Assert.AreEqual("2", result[1]);            
            Assert.AreEqual("Fizz", result[2]);
            Assert.AreEqual("4", result[3]);
            Assert.AreEqual("Buzz", result[4]);
            // ...
            Assert.AreEqual("FizzBuzz", result[14]);
        }
    }
}
