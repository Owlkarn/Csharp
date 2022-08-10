int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SecCifr(int sec)
{
    return (sec/10) % 10;
}

int number = ReadInt("Введите трехзначное число: ");
int length = (int)Math.Log10(number) + 1;

while(length != 3)
{
    number = ReadInt("Введено не трехзначное число. Введите новое число: ");
    length = (int)Math.Log10(number) + 1;
}

Console.WriteLine(SecCifr(number));
