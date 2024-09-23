using Tyuiu.StoyakinNM.Sprint1.Task1.V12.Lib;
namespace Tyuiu.StoyakinNM.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);
        }
    }
}