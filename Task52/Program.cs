// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || !isNumber2 || n <= 0 || m <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,] array = CreateRandomArray(m, n);
Console.WriteLine();
Print2DArray(array);
Console.WriteLine();
double[] result = FindSumAverageNumber(array);
Console.Write("Среднее арифметическое элементов каждого столбца: ");
PrintArray(result);

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

double[] FindSumAverageNumber(int[,] array)
{
    double[] result = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result[j] = sum / array.GetLength(0);
    }
    return result;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

