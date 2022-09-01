int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int rowsA = ReadInt("Введите количество строк матрицы А: ");
int columnsA = ReadInt("Введите количество столбцов матрицы А: ");
int[,] matrixA = new int[rowsA, columnsA];

int rowsB = ReadInt("Введите количество строк матрицы B: ");
int columnsB = ReadInt("Введите количество столбцов матрицы B: ");
int[,] matrixB = new int[rowsB, columnsB];

FillArray2D(matrixA);
PrintArray2D(matrixA);
FillArray2D(matrixB);
PrintArray2D(matrixB);

if (columnsA != rowsB) Console.WriteLine("Данные матрицы перемножить нельзя, т.к. количество столбцов матрицы А не равно количеству строк матрицы B");
else
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    PrintArray2D(matrixC);
}



