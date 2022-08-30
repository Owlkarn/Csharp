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
            array[i, j] = new Random().Next(2, 10);
        }
    }
}

int minArray(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j]) min = array[i, j];
        }
    }
    return min;
}

int maxArray(int[,] array)
{
    int max = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (max < array[i, j]) max = array[i, j];
        }
    }
    return max;
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int count = 0;

FillArray2D(numbers);
PrintArray2D(numbers);

int find = minArray(numbers);
int limit = maxArray(numbers);

while (find <= limit)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] == find) count++;
        }
    }
    if (count > 1 && count < 5) Console.WriteLine($"{find} встречается {count} раза");
    else if (count != 0) Console.WriteLine($"{find} встречается {count} раз");
    find++;
    count = 0;
}