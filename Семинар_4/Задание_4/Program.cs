int [] numbers = new int[8];

PrintArray(numbers);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write(array[i] + " ");
    }
}