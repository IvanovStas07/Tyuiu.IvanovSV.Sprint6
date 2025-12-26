using Tyuiu.IvanovSV.Sprint6.Task3.V7.Lib;
namespace Tyuiu.IvanovSV.Sprint6.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMinCharCount()
        {
            DataService ds = new DataService();

            string str = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';

            double res = ds.GetMinCharCount(str, chr);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}