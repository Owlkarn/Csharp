//Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше. На отгадывание дается 3 попытки.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число от 1 до 9: ");
int randomNumber = new Random().Next(0, 10);
int tries = 3;

while (tries > 0)
{
    if (number == randomNumber)
    {
        Console.WriteLine("Число угадано");
        break;
    }
    else if (number > randomNumber && tries != 1)
    {
        number = ReadInt("Меньше: ");
    }
    else if (number < randomNumber && tries != 1)
    {
        number = ReadInt("Больше: ");
    }
    tries --;
}
if (tries == 0)
{
    Console.WriteLine("Попытки закончились. Было загадано число " + randomNumber);
}