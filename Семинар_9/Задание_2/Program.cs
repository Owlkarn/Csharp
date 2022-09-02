int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    if (m == n)
    {
        Console.Write($"{m} ");
    }
}

int numberN = ReadInt("Введите число N: ");
int numberM = ReadInt("Введите число M: ");

NaturalNumber(numberM, numberN);

