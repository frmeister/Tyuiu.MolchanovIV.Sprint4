using Tyuiu.MolchanovIV.Sprint4.Task2.V9.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task2.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            var altRes = 1;

            int[] arr = new int[14];

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = rnd.Next(1, 7); if (arr[i] % 2 == 0) altRes *= arr[i];
            }

            var res = ds.Calculate(arr);

            Assert.AreEqual(altRes, res);
            
        }
    }
}
