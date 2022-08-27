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
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int findElement = ReadInt("Какой элемент найти? :");
int[,] numbers = new int[rows, columns];
int findRow = findElement / 10;
int findColumn = findElement % 10;

FillArray2D(numbers);
PrintArray2D(numbers);

if (findRow < rows && findColumn < columns) Console.WriteLine(numbers[findRow, findColumn]);
else Console.WriteLine("Такого числа в массиве нет");