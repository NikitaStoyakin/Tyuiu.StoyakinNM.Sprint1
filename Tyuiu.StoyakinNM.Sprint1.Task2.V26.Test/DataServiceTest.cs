using Newtonsoft.Json.Linq;
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
            int value = 1;
            int valueTwo = 10;
            var res = ds.CalculateMinutesSinceStart(value, valueTwo);
            Assert.AreEqual(70, res);
        }
    }
}