// // Console.SetCursorPosition() - позволяет поставить курсор в какую-либо точку консоли
// // Console.CursorVisible - изменяет видимость курсора
// // Console.ReadKey() - ожидает нажатия клавиши на клавиатуре и возвращает ConsoleKeyInfo
// // В ConsoleKeyInfo.Key можно получить ConsoleKey - это нажатая пользователем клавиша

// // 10.1. Задача написать игру-бродилку, где можно управлять персонажем стрелками вверх-вниз-влево-вправо. Область движения ограничена стенками ('*') в виде лабиринта, персонаж обозначается символом '@'. Область можно задать через двумерный массив. Персонаж должен иметь свободу движения в пределах его области.

// // У задачи есть продолжение

void PrintArray2D(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Labyrinth(int playerX, int playerY, string[,] field, int exitX, int exitY)
{
    ConsoleKeyInfo k;
    char playerChar = '@';
    do
    {
        Console.Clear();
        PrintArray2D(field);
        Console.SetCursorPosition(playerX, playerY);
        Console.Write(playerChar);


        k = Console.ReadKey(true);

        if (k.Key == ConsoleKey.UpArrow && field[playerY - 1, playerX] != "*")
            playerY--;
        else if (k.Key == ConsoleKey.DownArrow && field[playerY + 1, playerX] != "*")
            playerY++;
        else if (k.Key == ConsoleKey.LeftArrow && field[playerY, playerX - 1] != "*")
            playerX--;
        else if (k.Key == ConsoleKey.RightArrow && field[playerY, playerX + 1] != "*")
            playerX++;

        if (playerX == exitX && playerY == exitY)
        {
            Console.Clear();
            Console.WriteLine("YOU WIN!");
            break;
        }

    } while (k.Key != ConsoleKey.Escape);
}

Console.CursorVisible = false;

int startX = 7;
int startY = 0;
int stopX = 5;
int stopY = 6;

string[,] field1 = new string[7, 15];


for (int i = 0; i < field1.GetLength(0); i++)
{
    for (int j = 0; j < field1.GetLength(1); j++)
    {
        if (i == 0 || i == field1.GetLength(0) - 1 || j == 0 || j == field1.GetLength(1) - 1)
            field1[i, j] = "*";
        else
            field1[i, j] = " ";
    }
}
field1[0, 7] = field1[stopY, stopX] = " ";
field1[1, 2] = field1[1, 6] = field1[1, 8] = field1[2, 2] = field1[2, 4] = field1[2, 8] = field1[2, 9] = field1[2, 10] = field1[2, 11] = field1[2, 12] = field1[3, 2] = field1[3, 4] = field1[3, 5] = field1[3, 6] = field1[3, 10] = field1[3, 12] = field1[4, 2] = field1[4, 4] = field1[4, 6] = field1[4, 7] = field1[4, 8] = field1[5, 7] = field1[5, 10] = field1[5, 12] = field1[0, 0];

PrintArray2D(field1);
Labyrinth(startX, startY, field1, stopX, stopY);

Console.CursorVisible = true;