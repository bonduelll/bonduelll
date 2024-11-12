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

        // Вывод цифр числа, начиная с самой правой
        Console.WriteLine("Цифры числа в порядке их вывода (начиная справа):");
        while (N > 0)
        {
            // Получаем последнюю цифру
            int digit = N % 10;
            Console.WriteLine(digit);

            // Убираем последнюю цифру от числа
            N /= 10;
        }
    }
}
