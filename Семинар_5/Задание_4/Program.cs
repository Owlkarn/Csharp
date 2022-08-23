void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 150);
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

int min = 10;
int max = 99;
int size = 123;
int count = 0;
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < size; i++)
{
    if (numbers[i] <= max && numbers[i]>= min)
    {
        count += 1;
    }
}
Console.WriteLine(count);