using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Запрос вещественного числа V у пользователя
        Console.Write("Введите вещественное число V: ");
        double V = Convert.ToDouble(Console.ReadLine());

        // Запрос целого числа N
        Console.Write("Введите количество чисел N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Проверка на корректность введенного значения
        if (N <= 0)
        {
            Console.WriteLine("Ошибка: N должно быть больше 0.");
            return;
        }

        // Ввод элементов набора
        double[] numbers = new double[N];
        Console.WriteLine($"Введите {N} вещественных чисел, упорядоченных по возрастанию:");
        for (int i = 0; i < N; i++)
        {
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Поддержание упорядоченности после вставки V
        double[] result = new double[N + 1];
        bool inserted = false;
        int j = 0;

        // Вставка V в отсортированный массив
        for (int i = 0; i < N; i++)
        {
            if (!inserted && numbers[i] > V)
            {
                result[j++] = V; // Вставляем V
                inserted = true;
            }
            result[j++] = numbers[i]; // Копируем остальные элементы
        }

        // Если V больше всех элементов, добавляем его в конец
        if (!inserted)
        {
            result[j] = V;
        }

        // Вывод отсортированных чисел
        Console.WriteLine("Числа в порядке возрастания:");
        foreach (double number in result)
        {
            Console.WriteLine(number);
        }
    }
}
