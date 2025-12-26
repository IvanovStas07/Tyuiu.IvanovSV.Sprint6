using Tyuiu.IvanovSV.Sprint6.Task5.V29.Lib;

namespace Tyuiu.IvanovSV.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\konev\source\repos\Tyuiu.KonevaDD.Sprint6\Tyuiu.KonevaDD.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { 12, 12.89, 35, 13.83, 12.76 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}