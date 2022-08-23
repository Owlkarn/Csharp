void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
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

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Длина массива: ");
int newSize = size / 2;
int[] numbers = new int[size];
int[] newNumbers;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

if (size % 2 == 0)
{
    newNumbers = new int[newSize];

    for (int i = 0; i <= size / 2 - 1; i++)
    {
        newNumbers[i] = numbers[i] * numbers[size - i - 1];
    }
}
else
{
    newNumbers = new int[newSize + 1]; 

    for (int i = 0; i < newSize; i++)
    {
        newNumbers[i] = numbers[i] * numbers[size - i - 1];
    }
    newNumbers[newSize] = numbers[size / 2];
}
PrintArray(newNumbers);