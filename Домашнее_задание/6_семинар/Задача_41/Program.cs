Console.Write("Введите числа в формате a,b,c,d : ");
string numbers = Console.ReadLine();
string number = String.Empty;
char find = ',';
int stop1 = 0;
int stop2 = 0;
int i = 0;
int l = 0;
int size = 1;
int count = 0;

for (int k = 0; k < numbers.Length; k++)
{
    if (numbers[k] == find) size++;
}

int[] numbersInString = new int[size];

while (i < numbers.Length)
{
    if (i == numbers.Length - 1)
    {
        for (int j = stop2; j < numbers.Length; j++)
        {
            number += numbers[j];
        }
        numbersInString[size - 1] = Convert.ToInt32(number);
    }
    if (numbers[i] == find)
    {
        stop1 = i;
        for (int j = stop2; j < stop1; j++)
        {
            number += numbers[j];
        }
        numbersInString[l] = Convert.ToInt32(number);
        l++;
        stop2 = i + 1;
        number = String.Empty;
    }
    i++;
}

for (i = 0; i < size; i++)
{
    if (numbersInString[i] > 0) count++;
}

Console.WriteLine($"Вы ввели {count} чисел больше 0");



// Console.WriteLine("Введите числа через запятую: ");
// string input = Console.ReadLine();

// int[] numbers = ParseStringToArray(input);
// PrintArray(numbers);

// int[] ParseStringToArray(string input)
// {
//     int countNumbers = GetCountNumbersInString(input);
//     int[] numbers = new int[countNumbers];
//     int indexNumber = 0;
//     string substring = string.Empty;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] != ',')
//         {
//             substring += input[i];
//         }
//         else
//         {
//             numbers[indexNumber] = Convert.ToInt32(substring);
//             indexNumber++;
//             substring = string.Empty;
//         }
//     }
//     if (input[input.Length - 1] != ',')
//         numbers[indexNumber] = Convert.ToInt32(substring);
//     return numbers;
// }
// int GetCountNumbersInString(string input)
// {
//     int count;
//     if (input[input.Length - 1] == ',')
//         count = 0;
//     else
//         count = 1;

//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//             count++;
//     }
//     return count;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }