using Tyuiu.StoyakinNM.Sprint1.Task2.V26.Lib;
namespace Tyuiu.StoyakinNM.Sprint1.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 10;
            var res = ds.CalculateMinutesSinceStart(x, y);
            Assert.AreEqual(70, res);
        }
    }
}