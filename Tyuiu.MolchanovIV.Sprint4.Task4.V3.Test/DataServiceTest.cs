using Microsoft.ApplicationInsights;
using Tyuiu.MolchanovIV.Sprint4.Task4.V3.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int[,] arr = {  {7, 9, 7, 8, 6, },
                            { 4, 4, 4, 8, 6, },
                            { 7, 9, 6, 7, 6, },
                            { 7, 5, 4, 9, 8, },
                            { 9, 6, 4, 9, 8, } };

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            int wait = 0;
            var res = ds.Calculate(arr);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arr[i, j] % 2 != 0) wait += arr[i, j];
                }
            }

            Assert.AreEqual(wait, res);

        }
    }
}
