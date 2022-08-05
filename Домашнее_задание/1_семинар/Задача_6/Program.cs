Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()),
    ostatok = number % 2;

if (ostatok == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}
