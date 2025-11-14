using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint4.Task7.V11.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task7.V11
{
    class Program
    {
        static public void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;

            string value = "56789012";

            Console.Title = "Спринт #4 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"56789012\".                         *");
            Console.WriteLine("* Преобразуйте ее в матрицу 4 на 2 и подсчитайте                          *");
            Console.WriteLine("* количество нечетных чисел в матрице.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine(ds.Calculate(n, m , value));
        }
    }
}