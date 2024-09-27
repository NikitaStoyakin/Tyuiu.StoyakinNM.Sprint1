using Tyuiu.StoyakinNM.Sprint1.Task6.V7.Lib;
namespace Tyuiu.StoyakinNM.Sprint1.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "world";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter( strTest );
            string wait = "worl";
            Assert.AreEqual(wait, res);
        }
    }
}