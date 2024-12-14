using Tyuiu.FilimonchukED.Sprint3.Task3.V26.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char chr = 'e';
            int res = ds.GetCharCount(str, chr);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
