using Tyuiu.IvanovSV.Sprint6.Task0.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint6.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.444;
            Assert.AreEqual(wait, res);
        }
    }
}