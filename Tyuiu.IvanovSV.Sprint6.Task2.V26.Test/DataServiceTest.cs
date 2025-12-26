using Tyuiu.IvanovSV.Sprint6.Task2.V26.Lib;
namespace Tyuiu.IvanovSV.Sprint6.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            double[] wait = new double[]
            {
                8.04,
                6.68,
                4.84,
                1.76,
                0.45,
                0.5,
                -0.87,
                -2.42,
                -3.88,
                -6.83,
                -8.88
            };
            CollectionAssert.AreEqual(wait, dataService.GetMassFunction(-5, 5));

        }
    }
}