using Tyuiu.FilimonchukED.Sprint3.Task2.V6.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int strt = 1;
            int stp = 10;
            double a = 0.25;
            double res = ds.GetMultiplySeries(a, strt, stp);
            double wait = -0.03;
            Assert.AreEqual(wait, res);
        }
    }
}
