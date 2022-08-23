void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
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
int raznost = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int min = numbers[0];
int max = numbers[0];

for (int i = 0; i < size; i++)
{
    if (numbers[i] > max) max = numbers[i];
    if (numbers[i] < min) min = numbers[i]; 
}

raznost = max - min;

Console.WriteLine($"{max} minus {min} = {raznost}");