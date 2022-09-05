int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PowerNumber(int n, int c)
{
    int sum = 1;
    if (c > 0)
    {
        sum = PowerNumber(n, c - 1) * n;
    }
    return sum;
}

int number = ReadInt("Введите число: ");
int power = ReadInt("Введите степень: ");


Console.WriteLine(PowerNumber(number, power));


// Console.Write("Введите любое число: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write("Введите степень: ");
// int power = int.Parse(Console.ReadLine());

// int Power(int n, int pow)
// {
//     if (pow == 0)
//         return 1;

//     return n * Power(n, pow - 1);
// }

// Console.WriteLine($"{number} ^ {power} = " + Power(number, power));