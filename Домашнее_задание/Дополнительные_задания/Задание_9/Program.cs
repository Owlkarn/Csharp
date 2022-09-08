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


void PrintArray(int[] array)
{
    Console.Write("Текйщий массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
