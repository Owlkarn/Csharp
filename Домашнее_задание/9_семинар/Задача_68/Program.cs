int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    return n + 1;
}

int numberN = ReadInt("Введите натуральное положительное число N: ");
int numberM = ReadInt("Введите натуральное положительное число M: ");

if (numberM < 0 || numberN < 0)
    Console.WriteLine("Введены неверные числа");
else
    Console.WriteLine(Akkerman(numberM, numberN));
