using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер операции: \n1.Сложение  \n2.Вычитание  \n3.Умножение");

        int operation = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        switch (operation)
        {
            case 1:
                result = num1 + num2;
                Console.WriteLine($"Результат операции {result}");
                break;
            case 2:
                result = num1 - num2;
                Console.WriteLine($"Результат операции {result}");
                break;
            case 3:
                result = num1 * num2;
                Console.WriteLine($"Результат операции {result}");
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }
        Console.ReadKey();

        int[,] numbers = { { 1, 2, 3 , 1 }, { 4, 5, 6, 4 } };

        int rows = numbers.GetUpperBound(0) + 1;    // количество строк
        int columns = numbers.Length / rows;        // количество столбцов
                                                    // или так
                                                    // int columns = numbers.GetUpperBound(1) + 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{numbers[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    int DoOperation(int op, int a, int b)
    {
        return op switch
        {
            1 => a + b,
            2 => a - b,
            3 => a * b
        };
    }

    enum DayTime
    {
        Morning = 1,
        Afternoon = Morning,
        Evening = 2,
        Night = 2
    }
}