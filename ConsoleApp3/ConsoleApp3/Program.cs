// Задача 52. Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами.
// Напишите метод для поиска ср. арифметического значения каждого столбца.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program mi = new Program();
            double[,] arr;
            arr = mi.CreateArray();
            arr = mi.FillArray(arr);
            mi.ShowArray(arr);
            mi.AvarageOfColumn(arr);

            Console.ReadKey();
        }

        internal double[,] CreateArray()
        {
            Console.Write("Введите размер первого элемента двумерного массива: ");
            int first = Int32.Parse(Console.ReadLine());

            Console.Write("\nВведите размер второго элемента двумерного массива: ");
            int second = Int32.Parse(Console.ReadLine());

            double[,] arr = new double[first, second];

            return arr;
        }

        internal double[,] FillArray(double[,] arr)
        {
            double value = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rand = new Random();
                    value = Math.Round((rand.NextDouble()) * 100, 2);
                    arr[i, j] = value;
                }

            }
           
            return arr;
        }


        internal void ShowArray(double[,] arr)
        {
            const int cellWidth = 5;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {                    
                    Console.Write($"{arr[i, j],cellWidth} ");
                }
                Console.WriteLine(String.Empty);
            }
            Console.WriteLine(String.Empty);

        }

        internal void AvarageOfColumn (double[,] arr)
        {
            double avgColumn; // среднее арифметическое каждой колонки


            Console.Write("Среднее арифметическое каждого столбца:");
            for (int j = 0; j < arr.GetLength(1); j++)                
            {
                avgColumn = 0; // необходимо каждый раз обнулять переменную

                for (int i = 0; i < arr.GetLength(0); i++)
                {                    
                    avgColumn += avgColumn + arr[i,j];
                }

                avgColumn = avgColumn / arr.GetLength(0);
                avgColumn = Math.Round(avgColumn, 2);
                Console.Write($" {avgColumn};");
                                                
            }
            Console.WriteLine(String.Empty);
            
        }

    }
}
