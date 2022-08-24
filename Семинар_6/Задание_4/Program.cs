int ReadInt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
}

int size = ReadInt("Сколько чисел вывести? ");
int [] fibonachi = new int [size];
fibonachi[0] = 0;
fibonachi[1] = 1;

for (int i = 2; i < size; i++)
{
    fibonachi[i] = fibonachi[i-1] + fibonachi[i-2];
}

PrintArray(fibonachi);
