string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string command = "",
       programmEnd = "exit",
       writePassword = "",
       readPassword = "",
       password = "password",
       help = "help",
       name = "name",
       writeSetName = "",
       setName = "setname";


while (command.ToLower() != programmEnd)
{
    Console.Write("Может закончим? ");
    command = Console.ReadLine();

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
        if (writeSetName == " ")
        {
            Console.WriteLine("Имя не задано. Сначала нужно установить имя командой setname");
        }
        else if (writePassword == " ")
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