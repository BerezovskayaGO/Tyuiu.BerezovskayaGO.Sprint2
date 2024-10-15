using Tyuiu.BerezovskayaGO.Sprint2.Task4.V27.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = -11;
            double res = ds.Calculate(x, y);
            double wait = 162.000;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 2.000;
            Assert.AreEqual(wait, res);
        }
    }
}