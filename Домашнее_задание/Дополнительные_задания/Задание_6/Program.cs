int[] AddToArray(int[] array, int number)
{
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    newArray[array.Length] = number;
    return newArray;
}

int[] RemoveFromArray(int[] array, int number)
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < number - 1; i++)
    {
        newArray[i] = array[i];
    }
    for (int i = number; i < array.Length; i++)
    {
        newArray[i - 1] = array[i];
    }
    return newArray;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int addNumber = ReadInt("Введите число для добавления в массив: ");
numbers = AddToArray(numbers, addNumber);
PrintArray(numbers);

int removeNumber = ReadInt("Введите номер числа, которое нужно удалить из массива: ");
numbers = RemoveFromArray(numbers, removeNumber);
PrintArray(numbers);