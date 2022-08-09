int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);

int DelSecond(int a)
{
    int first = a / 100;
    int third = a % 10;
    int result = first * 10 + third;
    return result;
}

int res = DelSecond(randomNumber);
Console.WriteLine(res);