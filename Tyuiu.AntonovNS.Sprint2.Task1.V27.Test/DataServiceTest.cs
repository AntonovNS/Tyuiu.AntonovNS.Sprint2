using Tyuiu.AntonovNS.Sprint2.Task1.V27.Lib;
namespace Tyuiu.AntonovNS.Sprint2.Task1.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
            int a = 654, b = 325, c = 154, d = 333;
            var res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, true, false, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}