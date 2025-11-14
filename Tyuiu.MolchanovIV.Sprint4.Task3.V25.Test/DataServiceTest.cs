using Tyuiu.MolchanovIV.Sprint4.Task3.V25.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int[,] arr = {  { 7, 3, 5, 3, 6, },
                            { 4, 6, 2, 5, 7, },
                            { 2, 3, 3, 3, 5, },
                            { 2, 7, 7, 6, 2, },
                            { 6, 6, 4, 3, 6 } };
            var res = ds.Calculate(arr);
            int wait = 1;

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 4) wait *= arr[i, j];
                }
            }

            Assert.AreEqual(wait, res);


        }
    }
}
