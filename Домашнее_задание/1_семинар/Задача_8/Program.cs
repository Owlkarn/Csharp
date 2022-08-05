Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()),
    count = 1;

if (N > 0)
{
    while (count <= N)
    {
        if (count % 2 == 0 && count != 0)
        {
            Console.Write(count + ", ");
        }
    count++;
    }
}
else
{
    while (count >= N)
    {
        if (count % 2 == 0 && count != 0)
        {
            Console.Write(count + ", ");
        }
    count--;
    }
}