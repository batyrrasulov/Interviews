using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountryCount;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Test_Solution_ManyCountries()
        {
            var A = new int[7][];

            A[0] = new[] { 5, 4, 4 };
            A[1] = new[] { 4, 3, 4 };
            A[2] = new[] { 3, 2, 4 };
            A[3] = new[] { 2, 2, 2 };
            A[4] = new[] { 3, 3, 4 };
            A[5] = new[] { 1, 4, 4 };
            A[6] = new[] { 4, 1, 1 };

            var c = new Solution();
            int result = c.solution(A);
            Assert.AreEqual(11, result);
        }
    }
}
