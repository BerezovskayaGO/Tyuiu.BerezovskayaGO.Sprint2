using Tyuiu.BerezovskayaGO.Sprint2.Task5.V9.Lib;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int n = 06;
            int m = 28;
            string wait = "29.06";
            var res = ds.FindDateOfNextDay(m, n);
            Assert.AreEqual(wait, res);
        }
    }
}