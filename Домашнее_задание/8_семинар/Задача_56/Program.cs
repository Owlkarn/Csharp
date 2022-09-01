int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int[] sumRow = new int[rows];
int sum = 0;

FillArray2D(numbers);
PrintArray2D(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum += numbers[i, j];
    }
    sumRow[i] = sum;
    sum = 0;
}

PrintArray(sumRow);

int minSum = sumRow[0];
int minSumIndex = 0;

for (int i = 0; i < sumRow.Length; i++)
{
    if (minSum > sumRow[i])
    {
        minSum = sumRow[i];
        minSumIndex = i;
    }
}
Console.WriteLine($"Индекс строки с наименьшей суммой элементов {minSumIndex}");