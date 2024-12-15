using Tyuiu.FilimonchukED.Sprint3.Task5.V2.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int strt1 = 1;
            int strt2 = 1;
            int stp1 = 3;
            int stp2 = 12;
            int x = 5;
            double res = ds.GetSumSumSeries(x,strt1,strt2,stp1,stp2);
            double wait = 35.658;
            Assert.AreEqual(wait, res);
        }
    }
}
