void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 11);
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

int size = 5;
int[] numbers = new int[size];
int find = ReadInt("Введите число: ");
bool existNumber = false;
int i = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (i = 0; i < size; i++)
{
    if (numbers[i] == find)
    existNumber = true;
    break;
}
if(existNumber)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

// while (i < size)
// {
//     if (numbers[i] == find)
//     {
//         Console.WriteLine("да");
//         return;
//     }
//     i++;
// }
// Console.WriteLine("нет");