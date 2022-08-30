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

int[,] DelMinRowColumn(int[,] array, int xMin, int yMin)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i < xMin && j < yMin) newArray[i, j] = array[i, j];
            else if (i >= xMin && j < yMin) newArray[i, j] = array[i + 1, j];
            else if (j >= yMin && i < xMin) newArray[i, j] = array[i, j + 1];
            else newArray[i, j] = array[i + 1, j + 1];
        }
    }
    return newArray;
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

FillArray2D(numbers);
PrintArray2D(numbers);

int min = numbers[0, 0];
int iMin = 0;
int jMin = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (min > numbers[i, j])
        {
            min = numbers[i, j];
            iMin = i;
            jMin = j;
        }
    }
}

numbers = DelMinRowColumn(numbers, iMin, jMin);
PrintArray2D(numbers);

