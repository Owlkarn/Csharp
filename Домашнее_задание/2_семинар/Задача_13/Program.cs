int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int ThirdCifr(int third, int dlinna)
{
    return (third / (int)Math.Pow(10, dlinna - 3) % 10);
}

int number = ReadInt("Введите число: ");
int length = (int)Math.Log10(number) + 1;

while(length < 3)
{
    number = ReadInt("Третьей цифры нет. Введите новое число: ");
    length = (int)Math.Log10(number) + 1;
}

Console.WriteLine(ThirdCifr(number, length));