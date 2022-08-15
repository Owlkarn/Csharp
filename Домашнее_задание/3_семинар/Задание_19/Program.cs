Console.WriteLine("Введите 5-тизначное число: ");
string vhod = Console.ReadLine();
string rev = "";

while (vhod.Length != 5 || Convert.ToInt32(vhod) < 0)
{
    Console.WriteLine("Введено неверное число. Введите 5-тизначное число: ");
    vhod = Console.ReadLine();
}

for (int i = vhod.Length - 1; i >= 0; i--)
{
    rev += vhod[i]; 

}
if (rev == vhod)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}

