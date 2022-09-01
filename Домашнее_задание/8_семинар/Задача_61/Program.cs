int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = ReadInt("Введите количество строк: ");
int columns = rows * 2 - 1;
int[,] numbers = new int[rows, columns];
numbers[0, columns / 2] = 1;
numbers[1, columns / 2 - 1] = 1;
numbers[1, columns / 2 + 1] = 1;

for (int i = 2; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (j - 1 < 0) numbers[i, j] = numbers[i - 1, j + 1];
        else if (j + 1 == numbers.GetLength(1)) numbers[i, j] = numbers[i - 1, j - 1];
        else numbers[i, j] = numbers[i - 1, j - 1] + numbers[i - 1, j + 1];
    }
}
string[,] numbersString = new string[rows, columns];

for (int i = 0; i < numbersString.GetLength(0); i++)
{
    for (int j = 0; j < numbersString.GetLength(1); j++)
    {
        numbersString[i, j] = Convert.ToString(numbers[i, j]);
        if (numbersString[i, j] == "0") numbersString[i, j] = " ";
    }
}

PrintArray2D(numbersString);