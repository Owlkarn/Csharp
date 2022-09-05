int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int m, int n)
{
    if (m < n)
    {
        return m + SumDigit(m + 1, n);
    }
    if (m > n)
    {
        return n + SumDigit(m, n + 1);
    }
    return n;
}

int numberN = ReadInt("Введите число N: ");
int numberM = ReadInt("Введите число M: ");

Console.WriteLine(SumDigit(numberM, numberN));
