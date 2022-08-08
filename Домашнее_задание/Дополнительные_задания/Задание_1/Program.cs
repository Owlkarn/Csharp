Console.Write("Введите пароль: ");
string tryPassword = Console.ReadLine(),
       realPassword = "geekbrains",
       secretMessage = "Образовательная платформа";
int count = 0,
    tries = 3;

do
{
    if (tryPassword.ToLower() == realPassword)
    {
        Console.Write("Образовательная платформа");
        count = tries;
    }
    else if (count != tries - 1)
    {
        Console.Write("Пароль неверный, введите пароль: ");
        tryPassword = Console.ReadLine();
        count++;
    }
    else
    {
        Console.WriteLine("Пароль неверный. Попытки закончились");
        count = tries;
    }
} while (count < tries); 
