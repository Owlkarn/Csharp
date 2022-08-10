int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите номер дня недели: ");

while(number < 1 || number > 7)
{
    number = ReadInt("Введено некорректное значение. Введите номер дня недели: ");
}
if (number > 5 && number < 8)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}