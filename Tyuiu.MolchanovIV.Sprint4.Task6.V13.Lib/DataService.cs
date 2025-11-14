using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolchanovIV.Sprint4.Task6.V13.Lib
{
    public class DataService : ISprint4Task6V13
    {
        public int Calculate(string[] array)
        {
            int res = 0;

            Array.ForEach(array, s =>
            {
                if (s.Length > 4)
                    res++;
            });

            return res;
        }
    }
}
