using Tyuiu.StoyakinNM.Sprint1.Task4.V19.Lib;
namespace Tyuiu.StoyakinNM.Sprint1.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}