int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ax = ReadInt("Введите координату X первой точки: ");
int ay = ReadInt("Введите координату Y первой точки: ");
int bx = ReadInt("Введите координату X второй точки: ");
int by = ReadInt("Введите координату Y второй точки: ");
double rasst = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2));

Console.WriteLine($"Длина отрезка {rasst}");
