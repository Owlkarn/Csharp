int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x = ReadInt("Введите X: ");
int y = ReadInt("Введите Y: ");

if (x == 0 || y == 0) 
{
Console.WriteLine("Номер четверти определить не удалось");
return;
}