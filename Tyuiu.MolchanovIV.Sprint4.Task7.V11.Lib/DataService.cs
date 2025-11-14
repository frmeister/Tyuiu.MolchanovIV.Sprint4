using System.Data.Common;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MolchanovIV.Sprint4.Task7.V11.Lib
{
    public class DataService : ISprint4Task7V11
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            int[,] arr = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = int.Parse(value.Substring(i * m + j, 1));

                    if (arr[i, j] % 2 != 0) res++;
                }
            }

            return res;
        }
    }
}
