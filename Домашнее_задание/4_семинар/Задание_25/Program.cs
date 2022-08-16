int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите число А: ");
int b = ReadInt("Введите число B: ");
int res = 1;
// int proshe = (int)Math.Pow(a,b);
// Console.WriteLine(proshe);

for (int i = 1 ; i <= b; i++)
{
    res *= a;
}
Console.WriteLine(res);