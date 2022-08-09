int number1 = ReadInt("Введите первое число: ");
int number2 = ReadInt("Введите второе число: ");

int Kratnost(int a, int b)
{
    int res = 0;
    if (a > b)
    {
        if (a % b == 0)
        {
            res = 0;
        }
        else
        {
            res = a % b;
        }
    }
    else 
    {
        if (b % a == 0)
        {
            res = 0;
        }
        else
        {
            res = b % a;
        }
    }
    return res;
}

if (Kratnost(number1, number2) == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток " + Kratnost(number1, number2));
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}