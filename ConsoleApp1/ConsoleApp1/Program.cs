// Задача 47. Программа запрашивает от пользователя размерность двумерного массива. Напишите метод для заполнения массива случайными числами.
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). Округлите значения, генерируемые Random до двух знаков после запятой.
using System;
using FunctionArray;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            Program arraysFunction = new Program();

            double[,] arr = arraysFunction.DoubleCreateArray();
            arraysFunction.DoubleFillArray(arr);
            arraysFunction.DoubleShowArray(arr);
            
        }


        internal double [,] DoubleCreateArray()
        {
            Console.Write("Введите размер первого элемента двумерного массива: ");
            int first = Int32.Parse(Console.ReadLine());

            Console.Write("\nВведите размер второго элемента двумерного массива: ");
            int second = Int32.Parse(Console.ReadLine());

            double[,] arr = new double[first, second];

            return arr;
        }

        internal double[,] DoubleFillArray(double[,] arr)
        {
            double value;

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rand = new Random();
                    value = Math.Round((rand.NextDouble()) * 100, 2);
                    arr[i, j] = value;
                }
                
            }
            
            return arr;
        }

        internal void DoubleShowArray(double[,] arr)
        {
            const int cellWidth = 5;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j], cellWidth} ");
                }
                Console.WriteLine(String.Empty);
            }
            Console.WriteLine(String.Empty);
            
        }

    }
}
