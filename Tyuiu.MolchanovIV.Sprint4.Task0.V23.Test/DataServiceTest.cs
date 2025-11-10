using Tyuiu.MolchanovIV.Sprint4.Task0.V23.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task0.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            var res = ds.GetMultOddArrEl(array);

            Assert.AreEqual(res, 99225);

        }
    }
}
