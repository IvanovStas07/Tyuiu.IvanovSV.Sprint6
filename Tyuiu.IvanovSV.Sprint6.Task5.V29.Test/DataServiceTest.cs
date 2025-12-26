using System.Diagnostics;
using Tyuiu.IvanovSV.Sprint6.Task5.V29.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace Tyuiu.IvanovSV.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Станислав\source\repos\Tyuiu.IvanovSV.Sprint6\DataSprint6\InPutDataFileTask5V29.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, 12.89, 35, 13.83, 12.76 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
