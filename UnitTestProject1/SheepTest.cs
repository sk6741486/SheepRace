using Microsoft.VisualStudio.TestTools.UnitTesting;
using SheepRace;

namespace UnitTestProject1
{
    [TestClass]
    public class SheepTest
    {
        Punter newPunter = new Ali();

        [TestMethod]
        public void TestInstantiation() // Tests to make sure the Instantiation has worked by making sure the cash amounts are correct
        {
            int ExpectedCash = 50;
            int ActualCash = newPunter.Cash;
            Assert.AreEqual(ExpectedCash, ActualCash);
        }
    }
}
