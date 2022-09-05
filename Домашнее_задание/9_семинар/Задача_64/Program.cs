Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumber(number);

void NaturalNumber(int n)
{
    if (n == 1)
        Console.Write(n + " ");
    else
    {
        Console.Write(n + ", ");
        NaturalNumber(n - 1);        
    }
}