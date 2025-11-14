using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MolchanovIV.Sprint4.Task4.V3.Lib;

namespace Tyuiu.MolchanovIV.Sprint4.Task4.V3
{
    class Program
    {
        static public void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] arr = {  {7, 9, 7, 8, 6, },
                            { 4, 4, 4, 8, 6, },
                            { 7, 9, 6, 7, 6, },
                            { 7, 5, 4, 9, 8, },
                            { 9, 6, 4, 9, 8, } };

            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;

            Console.Title = "Спринт #4 | Выполнил: Молчанов И. В. | РППб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Молчанов Иван Владимирович | РППБ-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 4 до 9.              *");
            Console.WriteLine("* Найдите сумму нечетных элементов массива.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + " ,");
                }
                Console.WriteLine(" }");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(arr));
        }
    }
}