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
            double x = 1;
            double y = 1;
            double wait = 5.093;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}