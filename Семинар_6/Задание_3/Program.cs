int FindLength(int writeNumber)
{
    int n = 1;
    while (writeNumber > (int)Math.Pow(2, n)) n++;
    return n;
}

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

int tenNumber = ReadInt("Введите число: ");
int size = FindLength(tenNumber);
int div = 0;
int [] twoNumber = new int[size];

for (int i = twoNumber.Length - 1; i >= 0; i--)
{
    div = tenNumber / 2;
    twoNumber[i] = tenNumber % 2;
    tenNumber = div;
}

PrintArray(twoNumber);

// int number = ReadInt("Введите число: ");
// int baseNumber = 2;
// string result = string.Empty;

// while(number > 0)
// {
// result = number % baseNumber + result;
// number /= baseNumber;
// }
// Console.WriteLine(result);


// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }




// int inputNumber = ReadInt("Введите число: ");
// int baseNumber = 2;
// int number = inputNumber;
// int size = 0;

// while(number > 0)
// {
// size++;
// number /= baseNumber;
// }

// int[] result = new int[size];
// number = inputNumber;
// for(int i = 0; i < result.Length; i++)
// {
// result[result.Length - 1 - i] = number % baseNumber;
// number /= baseNumber;
// }
// PrintArray(result);


// void PrintArray(int[] array)
// {
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }