// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int heigth = EnterInt("Веедите число строк: ");
int width = EnterInt("Введите число столбцов: ");

int[,] numbers = new int[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);
FindAverage2DArray(numbers);

int EnterInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int heigth, int width)
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],9}");
        }
        Console.WriteLine();
    }
}

void FindAverage2DArray(int[,] numbers)
{   
    int sum;
    double average;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {   sum=0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sum+=numbers[i,j];
        }
        average=sum/Convert.ToDouble(numbers.GetLength(0));
        Console.WriteLine($"Среднее арифметическое в {j+1} столбце {average,9:F4}");
    }
}