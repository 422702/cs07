// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.

int heigth = EnterInt("Веедите число строк: ");
int width = EnterInt("Введите числостолбцов: ");

double[,] numbers = new double[heigth, width];
Fill2DArray(numbers, heigth, width);
Print2DArray(numbers, heigth, width);

int heigthElement = EnterInt("Веедите на какой строке находится элемент: ");
int widthElement = EnterInt("Введите на каком столбце находится элемент: ");
Find2DArray(numbers, heigthElement, widthElement);


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
void Find2DArray(double[,] numbers, int heigth, int width)
{
    if(heigth<numbers.GetLength(0) && width<numbers.GetLength(1) && heigth>0 && width>0)
        {
            Console.Write($"Искомый элемент {numbers[heigth-1,width-1],9:F4}");
        }
        else
        {
            Console.Write($"Такого элемента нет");
        }
}
