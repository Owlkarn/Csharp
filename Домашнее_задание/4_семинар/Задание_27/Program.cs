Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = (int)Math.Log10(number) + 1;
int i = 0;
int step = length - 1;
int sum = 0;

while (i < length)
{
    int chisl = (number / (int)Math.Pow(10, step) % 10);
    sum += chisl; 
    i++;
    step--;
}

Console.WriteLine(sum);