using Tyuiu.MolchanovIV.Sprint4.Task7.V11.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int rows = 4;
            int columns = 2;

            string value = "56789012";

            var res = ds.Calculate(rows, columns, value);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
