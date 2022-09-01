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
            array[i, j] = new Random().Next(1, 1001);
        }
    }
}

int minArray(int[,] array)
{
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j]) min = array[i, j];
        }
    }
    return min;
}

int maxArray(int[,] array)
{
    int max = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (max < array[i, j]) max = array[i, j];
        }
    }
    return max;
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
int count = 0;

FillArray2D(numbers);
PrintArray2D(numbers);

int find = minArray(numbers);
int limit = maxArray(numbers);

while (find <= limit)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] == find) count++;
        }
    }
    if (count > 1 && count < 5) Console.WriteLine($"{find} встречается {count} раза");
    else if (count != 0) Console.WriteLine($"{find} встречается {count} раз");
    find++;
    count = 0;
}



// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] numbers = new int[rows, columns];
// FillArray(numbers);
// PrintArray(numbers);

// SortArray(numbers);
// PrintArray(numbers);

// int countMatches = 1;
// int temp = numbers[0, 0];
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if (temp != numbers[i, j])
//         {
//             temp = numbers[i, j];
//             countMatches++;
//         }
//     }
// }

// int[,] frequencyDictionary = new int[2, countMatches];

// int frequencyDictionaryIndex = 0;
// frequencyDictionary[0, frequencyDictionaryIndex] = numbers[0, 0];
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if (frequencyDictionary[0, frequencyDictionaryIndex] == numbers[i, j])
//         {
//             frequencyDictionary[1, frequencyDictionaryIndex]++;
//         }
//         else
//         {
//             frequencyDictionaryIndex++;
//             frequencyDictionary[0, frequencyDictionaryIndex] = numbers[i, j];
//             frequencyDictionary[1, frequencyDictionaryIndex]++;
//         }
//     }
// }

// for (int i = 0; i < frequencyDictionary.GetLength(1); i++)
// {
//     Console.WriteLine($"Число {frequencyDictionary[0, i]} встречается {frequencyDictionary[1, i]} раз");
// }
// void SortArray(int[,] array) //сортируем массив от максимума к минимуму
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(0); k++)
//             {
//                 for (int l = 0; l < array.GetLength(1); l++)
//                 {
//                     if (array[k, l] < array[i, j])
//                     {
//                         int temp = array[i, j];
//                         array[i, j] = array[k, l];
//                         array[k, l] = temp;
//                     }
//                 }
//             }
//         }
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// Денис: void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("\n");
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }