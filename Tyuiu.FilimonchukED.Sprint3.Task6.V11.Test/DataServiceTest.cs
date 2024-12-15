using Tyuiu.FilimonchukED.Sprint3.Task6.V11.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int strt = 10; int stp = 19;
            int wait = 8;
            int res = ds.GetSumTheDivisors(strt, stp);
            Assert.AreEqual(wait, res);
        }
    }
}
