// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

if (!isNumber1 || n <= 0 || m <= 0 || !isNumber2)
{
    Console.WriteLine("Invalid number");
    return;
}

double[,] result = CreateRandomArray(m, n);
Console.WriteLine();
Print2DArray(result);
Console.WriteLine();

double[,] CreateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Convert.ToDouble(random.Next(-100, 100)) / 10;
        }
    }
    return array;
}

void Print2DArray(double[,] array)
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




