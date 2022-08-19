void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

Console.
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);