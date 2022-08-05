Console.Write("Введите пароль: ");
string tryPassword = Console.ReadLine(),
       realPassword = "geekbrains",
       secretMessage = "Образовательная платформа";
int count = 0;

while (count < 4)
{
    if (tryPassword.ToLower() == realPassword)
    {
        Console.Write("Образовательная платформа");
        count = 5;
    }
    else if (count != 2)
    {
        Console.Write("Пароль неверный, введите пароль: ");
        tryPassword = Console.ReadLine();
        count++;
    }
    else
    {
        Console.WriteLine("Пароль неверный. Попытки закончились");
        count = 5;
    }
}
