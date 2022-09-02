Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(NaturalNumber(number));

int NaturalNumber(int n)
{
    if (n == 1) return 1;
    else
    {
        Console.Write(NaturalNumber(n - 1) + " ");
    }

    return n;
}

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// NaturalNumber(number);

// void NaturalNumber(int n)
// {
//     if (n == 1)
//         Console.Write(n + " ");
//     else
//     {
//         NaturalNumber(n - 1);
//         Console.Write(n + " ");
//     }
// }