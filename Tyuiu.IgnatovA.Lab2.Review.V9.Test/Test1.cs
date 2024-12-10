using Tyuiu.IgnatovA.Lab2.Review.V9.Lib;

namespace Tyuiu.IgnatovA.Lab2.Review.V9.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CheckGetMassFunction()
        {
            var ds = new DataService();
            int start = -5;
            int end = 5;
            double expected1 = 0.47;
            double expected2 = -0.73;
            double expected3 = -0.68;
            double expected4 = -15.53;
            double expected5 = 8.70;
            double expected6 = 1.06;
            double expected7 = 0.73;
            double expected8 = -0.72;
            double expected9 = -0.54;
            double expected10 = -5.15;
            double expected11 = 20.94;
            var result = ds.GetMassFunction(start, end);
            Assert.AreEqual(expected1, result[0], 0.01);
            Assert.AreEqual(expected2, result[1], 0.01);
            Assert.AreEqual(expected3, result[2], 0.01);
            Assert.AreEqual(expected4, result[3], 0.01);
            Assert.AreEqual(expected5, result[4], 0.01);
            Assert.AreEqual(expected6, result[5], 0.01);
            Assert.AreEqual(expected7, result[6], 0.01);
            Assert.AreEqual(expected8, result[7], 0.01);
            Assert.AreEqual(expected9, result[8], 0.01);
            Assert.AreEqual(expected10, result[9], 0.01);
            Assert.AreEqual(expected11, result[10], 0.01);
        }
    }
}
