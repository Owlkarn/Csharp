int size = 12;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int sumNegativ = 0;
int sumPositiv = 0;

for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        sumPositiv += numbers[i];
        else
        sumNegativ += numbers[i];
    }

Console.WriteLine($"Сумма положительных элементов = {sumPositiv} \nСумма отрицательных элементов = {sumNegativ}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
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