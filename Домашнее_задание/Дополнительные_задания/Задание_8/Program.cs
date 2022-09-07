int GetCountNumbersInString(string input)
{
    int count;
    if (input[input.Length - 1] == ' ')
        count = 0;
    else
        count = 1;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
            count++;
    }
    return count;
}

int[] ParseStringToArray(string input)
{
    int countNumbers = GetCountNumbersInString(input);
    int[] numbers = new int[countNumbers];
    int indexNumber = 0;
    string substring = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            substring += input[i];
        }
        else
        {
            numbers[indexNumber] = Convert.ToInt32(substring);
            indexNumber++;
            substring = string.Empty;
        }
    }
    if (input[input.Length - 1] != ' ')
        numbers[indexNumber] = Convert.ToInt32(substring);
    return numbers;
}

int[] AddToArray(int[] array, int[] addArray)
{
    int[] newArray = new int[array.Length + addArray.Length];

    for (int i = 0; i < array.Length; i++) newArray[i] = array[i];

    for (int i = array.Length; i < newArray.Length; i++) newArray[i] = addArray[i - array.Length];

    return newArray;
}

int[] RemoveFromArray(int[] array, int[] delArray)
{
    string newDelArray = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        bool isFind = false;
        for (int j = 0; j < delArray.Length; j++)
        {
            if (array[i] == delArray[j]) isFind = true;
        }
        if (isFind == false) newDelArray += Convert.ToString(array[i]) + " ";
    }
    return ParseStringToArray(newDelArray);
}

void PrintArray(int[] array)
{
    Console.Write("Текйщий массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int SumArray(int[] array)
{
    int sumAr = 0;
    for (int i = 0; i < array.Length; i++) sumAr += array[i];
    return sumAr;
}

bool repeatProgramm = true;
int[] numbers = new int[0];
Console.WriteLine("Список команд:\n" +
"- SetNumbers – заполнение массива числами, введенными через пробел\n" +
"- AddNumbers – внесение новых чисел в массив\n" +
"- RemoveNumbers -  удаление чисел из массива\n" +
"- Numbers – ввывод текущего массива\n" +
"- Sum – вывод суммы всех элементов массива");

while (repeatProgramm)
{
    Console.WriteLine("Введите команду: ");
    string command = Console.ReadLine();
    switch (command.ToLower())
    {
        case "setnumbers":
            {
                Console.WriteLine("Введите числа через пробел(1 2 3 4 5...): ");
                string stringNumbers = Console.ReadLine();

                if (stringNumbers.ToLower() == "exit") repeatProgramm = false;

                else
                {
                    numbers = ParseStringToArray(stringNumbers);
                    PrintArray(numbers);
                    Console.WriteLine();
                }
                break;
            }
        case "addnumbers":
            {
                Console.WriteLine("Введите числа через пробел для добавления в массив: ");
                string addStringNumbers = Console.ReadLine();

                if (addStringNumbers.ToLower() == "exit") repeatProgramm = false;

                else
                {
                    int[] newNumbers = ParseStringToArray(addStringNumbers);
                    numbers = AddToArray(numbers, newNumbers);
                    PrintArray(numbers);
                    Console.WriteLine();
                }
                break;
            }
        case "removenumbers":
            {
                if (numbers.Length == 0)
                {
                    Console.WriteLine("Сначала нужно заполнить массив");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите числа через пробел для удаления из массива: ");
                    string delStringNumbers = Console.ReadLine();

                    if (delStringNumbers.ToLower() == "exit") repeatProgramm = false;

                    else
                    {
                        int[] delNumbers = ParseStringToArray(delStringNumbers);
                        numbers = RemoveFromArray(numbers, delNumbers);
                        PrintArray(numbers);
                        Console.WriteLine();
                    }
                    break;
                }
            }
        case "numbers":
            {
                if (numbers.Length == 0)
                {
                    Console.WriteLine("Сначала нужно заполнить массив");
                    break;
                }
                else
                {
                    PrintArray(numbers);
                    Console.WriteLine();
                    break;
                }
            }
        case "sum":
            {
                if (numbers.Length == 0)
                {
                    Console.WriteLine("Сначала нужно заполнить массив");
                    break;
                }
                else
                {
                    int sumNumbers = SumArray(numbers);
                    Console.WriteLine("Сумма элементов в массиве = " + sumNumbers);
                    break;
                }
            }
        case "exit":
            {
                repeatProgramm = false;
                break;
            }
        default:
            Console.WriteLine("Введена неверная команда. Попробуйте снова.");
            break;
    }
}


