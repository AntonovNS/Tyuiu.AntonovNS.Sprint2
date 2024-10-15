using Tyuiu.AntonovNS.Sprint2.Task4.V26.Lib;
namespace Tyuiu.AntonovNS.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 30, y = 5;
            var res = ds.Calculate(x, y);
            double wait = 900;
            Assert.AreEqual(wait, res);
        }
    }
}