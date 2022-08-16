Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int proizv = 1;

for (int i = 1; i <= number; i++)
{
    proizv *= i; 
}

Console.WriteLine(proizv);