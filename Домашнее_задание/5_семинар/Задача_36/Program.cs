void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
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
int sum = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 1; i < size; i += 2)
{
    sum += numbers[i];
}
Console.WriteLine(sum);