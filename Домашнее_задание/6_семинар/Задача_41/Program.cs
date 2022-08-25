Console.Write("Введите числа в формате a,b,c,d : ");
string numbers = Console.ReadLine();
string number = String.Empty;
char find = ',';
int stop1 = 0;
int stop2 = 0;
int i = 0;
int r = 0;
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
        numbersInString[r] = Convert.ToInt32(number);
        r++;
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