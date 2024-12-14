using Tyuiu.FilimonchukED.Sprint3.Task1.V27.Lib;
namespace Tyuiu.FilimonchukED.Sprint3.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            double Value = 0.75;
            double res = ds.GetMultiplySeries(Value,startValue,stopValue);
            double wait = 419028.1;
            Assert.AreEqual(wait, res);
        }
    }
}
