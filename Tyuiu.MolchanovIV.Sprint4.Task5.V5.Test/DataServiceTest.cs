using Microsoft.ApplicationInsights;
using Tyuiu.MolchanovIV.Sprint4.Task5.V5.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int[,] arr = new int[5, 5];

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            int wait = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    arr[i, j] = rnd.Next(-5, 8); if (arr[i, j] > 0) wait += arr[i, j];
                }
            }

            var res = ds.Calculate(arr);

            Assert.AreEqual(wait, res);
        }
    }
}
