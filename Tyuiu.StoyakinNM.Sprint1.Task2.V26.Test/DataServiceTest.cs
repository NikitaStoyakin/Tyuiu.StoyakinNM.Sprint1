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
            double x = 1;
            double y = 10;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(70, res);
        }
    }
}