Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
{
    Console.Write("Максимальное число - №1: " + number1);
}
else if (number2 > number1 && number2 > number3)
{
    Console.Write("Максимальное число - №2: " + number2);
}
else if (number3 > number1 && number3 > number2)
{
    Console.Write("Максимальное число - №3: " + number3);
}
else if (number1 == number2 && number1 > number3)
{
    Console.Write("Максимальные числа - №1 и №2: " + number1 + " " + number2);
}
else if (number1 == number3 && number1 > number2)
{
    Console.Write("Максимальные числа - №1 и №3: " + number1 + " " + number3);
}
else if (number2 == number3 && number2 > number1)
{
    Console.Write("Максимальные числа - №2 и №3: " + number2 + " " + number3);
}
else
{
    Console.Write("Введены одинаковые числа");
}