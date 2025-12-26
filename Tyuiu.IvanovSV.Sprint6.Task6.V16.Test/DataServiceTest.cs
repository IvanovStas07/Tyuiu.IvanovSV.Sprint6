using Tyuiu.IvanovSV.Sprint6.Task6.V16.Lib;
namespace Tyuiu.IvanovSV.Sprint6.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Станислав\source\repos\Tyuiu.IvanovSV.Sprint6\DataSprint6\InPutDataFileTask6V16.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "brIBPtX bWk";
            Assert.AreEqual(wait, res);
        }
    }
}
