string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string command = String.Empty,
       programmEnd = "exit",
       writePassword = String.Empty,
       readPassword = String.Empty,
       password = "password",
       help = "help",
       name = "name",
       writeSetName = String.Empty,
       setName = "setname";

Console.WriteLine("Список команд:");
        Console.WriteLine("SetName – Установить имя");
        Console.WriteLine("Password – Установить пароль");
        Console.WriteLine("Name – вывести имя после ввода пароля");
        Console.WriteLine("Exit – выход");
        Console.WriteLine("Help – список команд");

while (command.ToLower() != programmEnd)
{
    Console.Write("НЕ ЗАКРЫВАЙ МЕНЯ!!! : ");
    command = Console.ReadLine();

    switch (command)
{
    case "password":
    Console.WriteLine("x>0 y>0");
    break;

    case 2:
    Console.WriteLine("x<0 y>0");
    break;

    case 3:
    Console.WriteLine("x<0 y<0");
    break;

    case 4:
    Console.WriteLine("x>0 y<0");
    break;

    default:
    Console.WriteLine("Введено неверное число");
    break;
}
    if (command.ToLower() == password)
    {
        writePassword = ReadStr("Введите новый пароль: ");
        if (writePassword == programmEnd) break;
    }
    if (command.ToLower() == setName)
    {
        writeSetName = ReadStr("Введите новое имя пользователя: ");
        if (writeSetName == programmEnd) break;
    }
    if (command.ToLower() == name)
    {
        if (writeSetName == String.Empty)
        {
            Console.WriteLine("Имя не задано. Сначала нужно установить имя командой setname");
        }
        else if (writePassword == String.Empty)
        {
            Console.WriteLine("Пароль не задан. Сначала нужно установить пароль командой password");
        }
        else
        {
            readPassword = ReadStr("Введите пароль: ");
            if (readPassword == programmEnd) break;
            while (readPassword != writePassword || readPassword != programmEnd)
            {
                readPassword = ReadStr("Пароль не верный. Введите пароль: ");
            }
            if (readPassword == writePassword) Console.WriteLine(writeSetName);
        }
    }
    if (command.ToLower() == help)
    {
        Console.WriteLine("Список команд:");
        Console.WriteLine("SetName – Установить имя");
        Console.WriteLine("Password – Установить пароль");
        Console.WriteLine("Name – вывести имя после ввода пароля");
        Console.WriteLine("Exit – выход");
        Console.WriteLine("Help – список команд");
    }
}