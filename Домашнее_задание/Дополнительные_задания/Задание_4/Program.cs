string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string command = String.Empty,
       programmEnd = "exit",
       writePassword = String.Empty,
       savePassword = String.Empty,
       password = "password",
       help = "help",
       name = "name",
       writeSetName = String.Empty,
       saveName = String.Empty,
       setName = "setname";

Console.WriteLine("Список команд:");
Console.WriteLine("SetName – Установить/изменить имя (если не задан пароль, то появится приглашение для установки пароля)");
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
        if (savePassword == String.Empty)
        {
            writePassword = ReadStr("Установите новый пароль: ");
            if (writePassword == programmEnd)
            {
                writePassword = String.Empty;
                break;
            }
            savePassword = writePassword;
        }
        else
        {
            writePassword = ReadStr("Введите пароль: ");
            
            if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }

            while (writePassword != savePassword)
            {
                writePassword = ReadStr("Пароль не верный. Введите пароль: ");
                
                if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }
            }
            if (writePassword == savePassword) 
            {
                writePassword = ReadStr("Установите новый пароль: ");
                
                if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }
                
                savePassword = writePassword;
            }
        }
    }
    if (command.ToLower() == setName)
    {
        if (saveName == String.Empty && savePassword == String.Empty)
        {
            writeSetName = ReadStr("Установите новое имя пользователя: ");
            
            if (writeSetName == programmEnd)
                {
                    writeSetName = String.Empty;
                    break;
                }
            
            saveName = writeSetName;

            writePassword = ReadStr("Установите новый пароль: ");
            
            if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }

            savePassword = writePassword;
        }
        else if (writeSetName == String.Empty && writePassword != String.Empty)
        {
            writeSetName = ReadStr("Установите новое имя пользователя: ");
            
            if (writeSetName == programmEnd)
                {
                    writeSetName = String.Empty;
                    break;
                }
            
            saveName = writeSetName;

        }
        else
        {
            writePassword = ReadStr("Для смены имени введите пароль: ");

            if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }

            while (writePassword != savePassword)
            {
                writePassword = ReadStr("Пароль не верный. Для смены имени введите пароль: ");
                
                if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }
            }
            
            if (writePassword == savePassword) 
            {
                writeSetName = ReadStr("Установите новое имя пользователя: ");
                
                if (writeSetName == programmEnd)
                {
                    writeSetName = String.Empty;
                    break;
                }

                saveName = writeSetName;
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
            writePassword = ReadStr("Введите пароль: ");

            if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }

            while (writePassword != savePassword)
            {
                writePassword = ReadStr("Пароль не верный. Введите пароль: ");
                if (writePassword == programmEnd)
                {
                    writePassword = String.Empty;
                    break;
                }
            }

            if (writePassword == savePassword) Console.WriteLine(writeSetName);
        }
    }
    if (command.ToLower() == help)
    {
        Console.WriteLine("Список команд:");
        Console.WriteLine("SetName – Установить/изменить имя (если не задан пароль, то появится приглашение для установки пароля)");
        Console.WriteLine("Password – Установить/изменить пароль");
        Console.WriteLine("Name – вывести имя после ввода пароля");
        Console.WriteLine("Exit – выход");
        Console.WriteLine("Help – список команд");
    }
}