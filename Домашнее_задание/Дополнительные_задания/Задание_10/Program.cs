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

Console.CursorVisible = false;
ConsoleKeyInfo k;

int playerX = 7;
int playerY = 0;
char playerChar = '@';
int exitX = 5;
int exitY = 6;

do
{
    Console.Clear();

    string[,] field = new string[7, 15];


    for (int i = 0; i < field.GetLength(0); i++)
    {
        for (int j = 0; j < field.GetLength(1); j++)
        {
            if (i == 0 || i == field.GetLength(0) - 1 || j == 0 || j == field.GetLength(1) - 1)
                field[i, j] = "*";
            else
                field[i, j] = " ";
        }
    }
    field[0, 7] = field[exitY, exitX] = " ";
    field[1, 2] = field[1, 6] = field[1, 8] = field[2, 2] = field[2, 4] = field[2, 8] = field[2, 9] = field[2, 10] = field[2, 11] = field[2, 12] = field[3, 2] = field[3, 4] = field[3, 5] = field[3, 6] = field[3, 10] = field[3, 12] = field[4, 2] = field[4, 4] = field[4, 6] = field[4, 7] = field[4, 8] = field[5, 7] = field[5, 10] = field[5, 12] = field[0, 0];

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

Console.CursorVisible = true;