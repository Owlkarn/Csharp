int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");

if (number1 == number2 && number1 != 1)
{
    Console.WriteLine("Введены одинаковые числа");
}
if (number1 / number2 == number2 || number2 / number1 == number1)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}