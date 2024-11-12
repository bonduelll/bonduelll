using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод размеров матрицы M и N
        Console.Write("Введите положительное число M (количество строк): ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите положительное число N (количество столбцов): ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Ввод числа D
        Console.Write("Введите число D: ");
        int D = Convert.ToInt32(Console.ReadLine());

        // Ввод исходного набора чисел
        int[] numbers = new int[M];
        Console.WriteLine("Введите " + M + " положительных чисел через пробел:");
        string[] input = Console.ReadLine().Split(' ');

        // Заполнение массива
        for (int i = 0; i < M; i++)
        {
            numbers[i] = Convert.ToInt32(input[i]);
        }

        // Формирование матрицы
        int[,] matrix = new int[M, N];

        // Заполнение матрицы
        for (int i = 0; i < M; i++)
        {
            matrix[i, 0] = numbers[i]; // Заполнение первого столбца
            for (int j = 1; j < N; j++)
            {
                matrix[i, j] = matrix[i, j - 1] + D; // Заполнение следующих столбцов
            }
        }

        // Вывод матрицы
        Console.WriteLine("Сформированная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}