using Tyuiu.FilimonchukED.Sprint3.Task4.V2.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int strt = -5;
            int stp = 5;
            double res = ds.Calculate(strt, stp);
            double wait = 0.104;
            Assert.AreEqual(wait, res);
        }
    }
}
