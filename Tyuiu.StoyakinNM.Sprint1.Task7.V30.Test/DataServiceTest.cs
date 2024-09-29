using Tyuiu.StoyakinNM.Sprint1.Task7.V30.Lib;
namespace Tyuiu.StoyakinNM.Sprint1.Task7.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 11.978;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}