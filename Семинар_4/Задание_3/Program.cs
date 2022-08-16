//int [] numbers = new int[7] {1, 1, 4, 7, 5, 3, 2};
// int [] numbers = {1, 1, 4, 7, 5, 3, 2};
// int [] numbers = new int[] {1, 1, 4, 7, 5, 3, 2};

int[] numberA = {1, 2, 3};
int[] numberB = {10, 11, 12};

numberB = numberA;
numberA[2] = 50;
PrintArray(numberA);
PrintArray(numberB);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
