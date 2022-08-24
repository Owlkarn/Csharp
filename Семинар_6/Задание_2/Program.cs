int ReadInt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int x = ReadInt("Введите первое число: ");
int y = ReadInt("Введите второе число: ");
int z = ReadInt("Введите третье число: ");

//bool isCheckSideX = x < y + z;
//bool isCheckSideY = y < x + z;
//bool isCheckSideZ = z < y + x;

//if(isCheckSideX && isCheckSideY && isCheckSideZ)

if (x < y + z && y < x + z && z < x + y) Console.WriteLine("Треугольник есть");
else Console.WriteLine("Треугольника нет");
