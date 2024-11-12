
    static void Main(string[] args)
    {
        // Ввод размеров матрицы M и N
        Console.Write("Введите четное число M (количество строк): ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите четное число N (количество столбцов): ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Проверка на четность
        if (M % 2 != 0 || N % 2 != 0)
        {
            Console.WriteLine("Ошибки: M и N должны быть четными числами.");
            return;
        }

        // Создание и заполнение матрицы
        int[,] matrix = new int[M, N];
        Console.WriteLine("Введите элементы матрицы (размером " + M + "x" + N + "):");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Обмен местами левой нижней и правой верхней четверти матрицы
        int midRow = M / 2;
        int midCol = N / 2;

        for (int i = 0; i < midRow; i++)
        {
            for (int j = 0; j < midCol; j++)
            {
                // Сохраняем значение из левой нижней четверти
                int temp = matrix[midRow + i, j];
                // Перемещаем значение из правой верхней четверти
                matrix[midRow + i, j] = matrix[i, midCol + j];
                // Перемещаем сохраненное значение в правую верхнюю четверть
                matrix[i, midCol + j] = temp;
            }
        }

        // Вывод измененной матрицы
        Console.WriteLine("Измененная матрица:");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
