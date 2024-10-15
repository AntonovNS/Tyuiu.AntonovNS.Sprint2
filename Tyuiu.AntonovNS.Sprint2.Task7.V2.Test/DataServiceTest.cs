using Tyuiu.AntonovNS.Sprint2.Task7.V2.Lib;
namespace Tyuiu.AntonovNS.Sprint2.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1, y = 1;
            bool wait = false;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait,res);
        }
    }
}