Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int length = (int)Math.Log10(number) + 1;

Console.WriteLine(length);

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while(number > 0)
// {
// number /= 10;
// count++;
// }

// Console.WriteLine(count);