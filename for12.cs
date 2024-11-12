
using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрос значения N у пользователя
        Console.Write("Введите целое число N (> 0): ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Проверка на корректность введенного значения
        if (N <= 0)
        {
            Console.WriteLine("Ошибка: N должно быть больше 0.");
            return;
        }

        // Инициализация переменной для произведения
        double product = 1.0;

        // Вычисление произведения от 1.1 до 1 + N
        for (double i = 1.1; i <= 1 + N; i += 0.1)
        {
            product *= i;
        }

        // Вывод результата
        Console.WriteLine($"Произведение от 1.1 до {1 + N} равно: {product}");
    }
}
