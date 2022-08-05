Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Первое число больше второго, т.к. " + number1 + " больше чем " + number2);
}
else
{
    Console.WriteLine("Второе число больше первого, т.к. " + number2 + " больше чем " + number1);
}