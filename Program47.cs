// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int heigth = EnterInt("Веедите число строк: ");
int width = EnterInt("Введите числостолбцов: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);

int EnterInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().NextDouble();
        }
    }
}

void Print2DArray(double[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],9:F4}");
        }
        Console.WriteLine();
    }
}
