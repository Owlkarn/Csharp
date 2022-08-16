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
Console.WriteLine("SetName – Установить/изменить имя");
Console.WriteLine("Password – Установить/изменить пароль");
Console.WriteLine("Name – вывести имя после ввода пароля");
Console.WriteLine("Exit – выход");
Console.WriteLine("Help – список команд");

while (command.ToLower() != programmEnd)
{
    Console.Write("НЕ ЗАКРЫВАЙ МЕНЯ!!! : ");
    command = Console.ReadLine();

    if (command.ToLower() == password)
    {
        if (writePassword == String.Empty)
        {
            writePassword = ReadStr("Установите новый пароль: ");
            if (writePassword == programmEnd)
            {
                writePassword = String.Empty;
                break;
            }
        }
        else
        {
            readPassword = ReadStr("Введите пароль: ");

            while (readPassword != writePassword)
            {
                readPassword = ReadStr("Пароль не верный. Введите пароль: ");
                if (readPassword == programmEnd)
                {
                    readPassword = String.Empty; // стоп тут был
                    break;
                }
            }
            if (readPassword == writePassword) 
            {
                writePassword = ReadStr("Установите новый пароль: ");
            }
        }
    }
    if (command.ToLower() == setName)
    {
        if (writeSetName == String.Empty && writePassword == String.Empty)
        {
            writeSetName = ReadStr("Установите новое имя пользователя: ");writePassword = ReadStr("Установите новый пароль: ");
        }
        else if (writeSetName == String.Empty && writePassword != String.Empty)
        {
            writeSetName = ReadStr("Установите новое имя пользователя: ");
        }
        else
        {
            readPassword = ReadStr("Для смены имени введите пароль: ");

            while (readPassword != writePassword)
            {
                readPassword = ReadStr("Пароль не верный. Для смены имени введите пароль: ");
            }
            if (readPassword == writePassword) 
            {
                writeSetName = ReadStr("Установите новое имя пользователя: ");
            }
        }
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

            while (readPassword != writePassword && readPassword != programmEnd)
            {
                readPassword = ReadStr("Пароль не верный. Введите пароль: ");
            }
            if (readPassword == writePassword) Console.WriteLine(writeSetName);
        }
    }
    if (command.ToLower() == help)
    {
        Console.WriteLine("Список команд:");
        Console.WriteLine("SetName – Установить/изменить имя");
        Console.WriteLine("Password – Установить/изменить пароль");
        Console.WriteLine("Name – вывести имя после ввода пароля");
        Console.WriteLine("Exit – выход");
        Console.WriteLine("Help – список команд");
    }
}