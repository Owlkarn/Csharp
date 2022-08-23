﻿void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
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

int size = 12;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < size; i++) numbers[i] *= -1;

PrintArray(numbers);

