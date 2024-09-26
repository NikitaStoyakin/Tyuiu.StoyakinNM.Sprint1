using Tyuiu.StoyakinNM.Sprint1.Task5.V6.Lib;
namespace Tyuiu.StoyakinNM.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int k = 1;
            DataService ds = new DataService();
            int res = ds.Calculate(k);

            int result = Convert.ToInt32(res);

            int wait = 1;
            Assert.AreEqual(wait, result);
        }
    }
}