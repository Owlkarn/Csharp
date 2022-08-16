int number = ReadInt("Введите количество элементов массива: ");
int min = ReadInt("Введите нижний предел элементов массива: ");
int max = ReadInt("Введите верхний предел элементов массива: ");

while (max <= min)
{
    min = ReadInt("Введите нижний предел элементов массива: ");
    max = ReadInt("Введите верхний предел элементов массива: ");
}

int [] mas = new int[number];

FillArray(mas, min, max);
PrintArray(mas);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void FillArray(int[] array, int nummin, int nummax)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(nummin, nummax + 1);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}