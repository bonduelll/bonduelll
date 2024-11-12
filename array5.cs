using System;

class Program
{
    static void Main(string[] args)
    {
        // Введите значение N, которое должно быть больше 2
        Console.Write("Введите целое число N (> 2): ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Проверка на значение N
        if (N <= 2)
        {
            Console.WriteLine("Число N должно быть больше 2.");
            return;
        }

        // Создание массива для первых N чисел Фибоначчи
        int[] fibArray = new int[N];

        // Инициализация первых двух элементов
        fibArray[0] = 0; // F(0) = 0
        fibArray[1] = 1; // F(1) = 1

        // Генерация чисел Фибоначчи
        for (int i = 2; i < N; i++)
        {
            fibArray[i] = fibArray[i - 1] + fibArray[i - 2]; // F(n) = F(n-1) + F(n-2)
        }

        // Вывод массива
        Console.WriteLine($"Первые {N} чисел Фибоначчи:");
        for (int i = 0; i < N; i++)
        {
            Console.Write(fibArray[i] + " ");
        }
    }
}