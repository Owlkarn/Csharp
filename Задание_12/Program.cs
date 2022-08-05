Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()),
    antiNumber = - number;

while (antiNumber <= number)
{
    Console.Write(antiNumber + " ");
    antiNumber ++;
}