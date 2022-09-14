// Задача 50. Напишите программу, которая на вход принимает число, ищет его в двумерном массиве, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет

Console.Write("Введите размерность m: ");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int m);

Console.Write("Введите размерность n: ");
bool isNumber2 = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Введите искомое число: ");
bool isNumber3 = int.TryParse(Console.ReadLine(), out int x);

if (!isNumber1 || !isNumber2 || n <= 0 || m <= 0)
{
    Console.WriteLine("Invalid number");
    return;
}

int[,] array = CreateRandomDoubleArray(m, n);
Console.WriteLine();
Print2DArray(array);
Console.WriteLine();
int[] resultArray = FindNumberInDoubleArray(x, array);
if (resultArray[0] == -1)
{
    Console.Write("Искомый элемент отсутствует");
}
else
{
    Console.Write($"Индекс найденного числа: ({resultArray[0]}, {resultArray[1]})");
}
Console.WriteLine();

int[,] CreateRandomDoubleArray(int m, int n)
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

int[] FindNumberInDoubleArray(int number, int[,] array)
{
    int[] result = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(number == array[i, j])
        
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
        
    }
    result[0] = -1;
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
