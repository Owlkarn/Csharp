int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int n, int c)
{
    int sum = 0;
    if (c > 0)
    {
        sum = SumNumber(n, c - 1) + n / (int)Math.Pow(10, c - 1) % 10;
    }
    return sum;
}

int number = ReadInt("Введите число: ");
int count = (int)Math.Log10(number) + 1;


Console.WriteLine(SumNumber(number, count));



// Console.Write("Введите любое число: ");
// int n = int.Parse(Console.ReadLine());

// int SumDigits(int n)
// {
//     if (n > 10)
//         return n % 10 + SumDigits(n / 10);

//     return n;
// }

// Console.WriteLine("Сумма цифр заданного числа равна: " + SumDigits(n));