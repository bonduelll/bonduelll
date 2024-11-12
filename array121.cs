using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ввод числа K (> 0)
        Console.Write("Введите целое число K (> 0): ");
        int K = Convert.ToInt32(Console.ReadLine());

        // Ввод массива
        Console.Write("Введите длину массива N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[N];
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] elements = Console.ReadLine().Split(' ');

        // Заполнение массива
        for (int i = 0; i < N; i++)
        {
            arr[i] = Convert.ToInt32(elements[i]);
        }

        // Преобразование массива
        int[] transformedArray = TransformArray(arr, K);

        // Вывод результата
        Console.WriteLine("Результирующий массив:");
        Console.WriteLine(string.Join(" ", transformedArray));
    }

    static int[] TransformArray(int[] arr, int K)
    {
        List<int> resultList = new List<int>();
        int seriesCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            // Добавляем элемент в результирующий список
            resultList.Add(arr[i]);

            // Проверяем, если это начало новой серии
            if (i == 0 || arr[i] != arr[i - 1])
            {
                seriesCount++;

                // Если K-ая серия, удваиваем ее длину
                if (seriesCount == K)
                {
                    var seriesValue = arr[i];
                    int start = resultList.Count - 1;

                    // Ищем конец этой серии
                    while (i < arr.Length && arr[i] == seriesValue)
                    {
                        resultList.Add(arr[i]);
                        i++;
                    }

                    // Удаляем добавленные элементы для правильного дублирования
                    resultList.RemoveRange(start, resultList.Count - start - 1);
                }
            }
        }

        return resultList.ToArray();
    }
}