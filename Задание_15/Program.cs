int [] array = {1, 234, 345, 4578, 57, 6789, 744, 89, 234};

int n = array.Length;
int find = 234;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}