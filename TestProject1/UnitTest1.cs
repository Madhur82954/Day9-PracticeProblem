using Day9_Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PriceList()
        {
            int[] arr = { 5, 5, 4, 7, 4, 1, 11 };
            int one = 7;
            int morethanone = 5;
            problem problem = new problem();
            int[] Expected = problem.ShopkeeperList();
            Assert.AreEqual(Expected[0], one);
            Assert.AreEqual(Expected[1], morethanone);
        }
        [TestMethod]
        public void SwapCompetetion()
        {
            SwapCompetetion swap = new SwapCompetetion();
            string actual = "YES";
            string Expected = swap.checkString("part","trap");
            Assert.AreEqual(actual,Expected);
        }
    }
}
