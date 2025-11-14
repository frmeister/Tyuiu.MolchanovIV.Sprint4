using Tyuiu.MolchanovIV.Sprint4.Task6.V13.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string[] str = {"Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi"};
            var res = ds.Calculate(str);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}
