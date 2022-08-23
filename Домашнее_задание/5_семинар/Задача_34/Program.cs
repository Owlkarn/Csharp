void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int size = ReadInt("Введите длину массива: ");
int[] numbers = new int[size];
int count = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < size; i++)
{
    if (numbers[i] % 2 == 0)
    count++;
}
Console.WriteLine(count);