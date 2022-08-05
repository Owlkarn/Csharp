Console.Write("Введите число: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
//int number = Convert.ToInt32(Console.ReadLine());
int sqrNumber = number * number;
Console.WriteLine(number + " в квадрате равно " + sqrNumber);