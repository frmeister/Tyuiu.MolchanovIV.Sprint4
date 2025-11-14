using Tyuiu.MolchanovIV.Sprint4.Task1.V17.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[] arr = new int[] { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            var res = ds.Calculate(arr);
            Assert.AreEqual(34, res);
        }
    }
}
