int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array)
{
    int area = (int)Math.Log10(array.GetLength(0) * array.GetLength(1)) + 2;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0," + area + "}", array[i, j]);;
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int size = ReadInt("Введите размер массива: ");
int[,] numbers = new int[size, size];
int i = 0;
int j = 0;
int temp = 0;
int count = 0;

while (count < size)
{
    for (j = 0; j < size; j++)
    {
        i = count;
        if (numbers[i, j] == 0) numbers[i, j] = ++temp;
    }
    for (i = 0; i < size; i++)
    {
        j = size - count - 1;
        if (numbers[i, j] == 0) numbers[i, j] = ++temp;
    }
    for (j = size - 1; j >= 0; j--)
    {
        i = size - count - 1;
        if (numbers[i, j] == 0) numbers[i, j] = ++temp;
    }
    for (i = size - 1; i >= 0; i--)
    {
        j = count;
        if (numbers[i, j] == 0) numbers[i, j] = ++temp;
    }
    count++;
}

PrintArray2D(numbers);