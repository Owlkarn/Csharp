int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

void FillArray3D(int[,,] array, int min, int max)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                bool newRand = true;
                while (newRand)
                {
                    newRand = false;
                    temp = new Random().Next(min, max + 1);
                    for (int l = 0; l < array.GetLength(0); l++)
                    {
                        for (int m = 0; m < array.GetLength(1); m++)
                        {
                            for (int n = 0; n < array.GetLength(2); n++)
                            {
                                if (temp == array[l, m, n])
                                {
                                    newRand = true;
                                }
                            }
                        }
                    }
                }
                array[i, j, k] = temp;
            }
        }
    }
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int deep = ReadInt("Введите глубину: ");
int[,,] numbers = new int[rows, columns, deep];
int minNumber = ReadInt("Введите минимальное число для заполнения массива: ");
int maxNumber = ReadInt("Введите максимальное число для заполнения массива: ");

if (maxNumber - minNumber + 1 < rows * columns * deep) Console.WriteLine("Заполнить массив неповторяющимися числами невозможно");

else
{
    FillArray3D(numbers, minNumber, maxNumber);
    PrintArray3D(numbers);
}


