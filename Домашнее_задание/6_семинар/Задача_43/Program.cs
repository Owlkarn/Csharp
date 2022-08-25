double ReadDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
    
}
Console.WriteLine("Даны две прямые, заданные уравнениями: y = k1 * x + b1 и y = k2*x + b2");

double k1 = ReadDouble("Введите переменную k1: ");
double b1 = ReadDouble("Введите переменную b1: ");
double k2 = ReadDouble("Введите переменную k2: ");
double b2 = ReadDouble("Введите переменную b2: ");
double x = 0;
double y = 0;

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения двух прямых: ({x};{y})");
}



