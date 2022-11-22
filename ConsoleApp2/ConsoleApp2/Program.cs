// Задача 50. Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции.
// Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. Размерность массива определить самостоятельно.
// Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.


using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program functionArrray = new();
            int[,] arr;

            arr = functionArrray.CreateArray();
            functionArrray.FillArray(arr);
            functionArrray.GetElementByIndex(arr);
            
        }

        internal int[,] CreateArray()
        {
            Console.Write("\nВведите размер первого элемента двумерного массива: ");
            int first = Int32.Parse(Console.ReadLine());

            Console.Write("Введите размер второго элемента двумерного массива: ");
            int second = Int32.Parse(Console.ReadLine());

            int[,] arr = new int[first, second];

            return arr;
        }

        internal int[,] FillArray(int[,] arr)
        {
            int value;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Random rand = new Random();
                    value = rand.Next(1, 100);
                    arr[i, j] = value;
                }

            }

            return arr;
        }


        internal void ShowArray(int[,] arr)
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

        int GetElementByIndex(int[,] arr)
        {

            Console.Write("\nПоиск элемента по индексу двумерного массива.\n" +
                "Введите значение первого элемента двумерного массива: ");
            int first = Int32.Parse(Console.ReadLine());

            Console.Write("Введите значение второго элемента двумерного массива: ");
            int second = Int32.Parse(Console.ReadLine());


            if ((first < arr.GetLength(0)) && (second < arr.GetLength(1)) && (first >= 0) && (second >=0))
            {
                Console.Write($"Элемент с индексом [{first}, {second}]: {arr[first, second]}.");
                return arr[first, second];
            }
            
            
            Console.Write($"Элемента с индексом [{first}, {second}] в проверяемом массиве несуществует.");
            return 000;
        }




    }
}
