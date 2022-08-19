double ReadDouble(string message)
{
    Console.Write(message);
    double znachenie = Convert.ToDouble(Console.ReadLine());
    while (znachenie < 0)
    {
        Console.Write("Введено неверное значение, введите новое: ");
        znachenie = Convert.ToDouble(Console.ReadLine());
    }
    return znachenie;
}

string ReadStr(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

double ProverkaNaNalichie(double nadoValuti, double estValuti)
{
    bool proverka = true;
    while (proverka)
    {
        if (nadoValuti > estValuti)
        {
            Console.WriteLine(); 
            Console.Write("На вашем счете недостаточно средств, введите новое значение: ");
            nadoValuti = Convert.ToDouble(Console.ReadLine());
        }
        else proverka = false;        
    }
    return nadoValuti;
}

string ProverkaNaValutu(string nameValuta, string[] spisokValut)
{
    bool proverka = true;
    while (proverka)
    {
        if (spisokValut.Contains(nameValuta))
        {
            proverka = false;
        }
        else
        {
            Console.WriteLine(); 
            Console.Write("Такой валюты у Вас нет, введите новое значение: ");
            nameValuta = Console.ReadLine();
        }
    }
    return nameValuta;
}

double Vichitanie(double ostatok, double vichitaemoe)
{
    ostatok -=vichitaemoe;
    return ostatok;
}

double Convertirovanie(string valuta1, double perevodVValutu)
{
switch (valuta1.ToLower())
            {
                case "рубли":
                    break;

                case "доллары":
                    perevodVValutu *= 60;
                    break;

                case "евро":
                    perevodVValutu *= 70;
                    break;

                case "юани":
                    perevodVValutu *= 15;
                    break;

                case "фунты":
                    perevodVValutu *= 80;
                    break;
            }
            return perevodVValutu;
}

bool isExitString(string exit)
{
    return exit != "exit";
}

string[] koshelek = {"рубли", "доллары", "евро", "юани", "фунты"};
string[]  programmEnd = {"e", "x", "i", "t"};
string  convertiruemayaValuta = String.Empty,
        valutaVKotoruyuConvertiruem = String.Empty;
bool proverkaNaVihod = true;

Console.WriteLine("Укажите какое количество каждой валюты у Вас имеется:");
double rubli = ReadDouble("Рубли: ");
double dollari = ReadDouble("Доллары: ");
double euro = ReadDouble("Евро: ");
double yuani = ReadDouble("Юани: ");
double funti = ReadDouble("Фунты: ");
Console.WriteLine();        

while (true)
{
    Console.WriteLine($"Ваш баланс: \nРубли: {rubli} \nДоллары: {dollari} \nЕвро: {euro} \nЮани: {yuani} \nФунты: {funti}");
    
    Console.WriteLine(); 
    convertiruemayaValuta = ReadStr("Введите конвертируемую валюту: ");
    proverkaNaVihod = isExitString(convertiruemayaValuta);
    if (proverkaNaVihod == false) break;
    convertiruemayaValuta = ProverkaNaValutu(convertiruemayaValuta, koshelek);
    proverkaNaVihod = isExitString(convertiruemayaValuta);
    if (proverkaNaVihod == false) break;

    double kolichestvoKonvertiruemoyValuti = ReadDouble("Введите количество конвертируемой валюты: ");

    if (convertiruemayaValuta.ToLower() == koshelek[0]) 
    {
        kolichestvoKonvertiruemoyValuti = ProverkaNaNalichie(kolichestvoKonvertiruemoyValuti, rubli);
        rubli = Vichitanie(rubli, kolichestvoKonvertiruemoyValuti);
    }
    else if (convertiruemayaValuta.ToLower() == koshelek[1]) 
    {
        kolichestvoKonvertiruemoyValuti = ProverkaNaNalichie(kolichestvoKonvertiruemoyValuti, dollari);
        dollari = Vichitanie(dollari, kolichestvoKonvertiruemoyValuti);
    }
    else if (convertiruemayaValuta.ToLower() == koshelek[2]) 
    {
        kolichestvoKonvertiruemoyValuti = ProverkaNaNalichie(kolichestvoKonvertiruemoyValuti, euro);
        euro = Vichitanie(euro, kolichestvoKonvertiruemoyValuti);
    }
    else if (convertiruemayaValuta.ToLower() == koshelek[3]) 
    {
        kolichestvoKonvertiruemoyValuti = ProverkaNaNalichie(kolichestvoKonvertiruemoyValuti, yuani);
        yuani = Vichitanie(yuani, kolichestvoKonvertiruemoyValuti);
    }
    else if (convertiruemayaValuta.ToLower() == koshelek[4]) 
    {
        kolichestvoKonvertiruemoyValuti = ProverkaNaNalichie(kolichestvoKonvertiruemoyValuti, funti);
        funti = Vichitanie(funti, kolichestvoKonvertiruemoyValuti);
    }

    valutaVKotoruyuConvertiruem = ReadStr("Введите валюту, в которую производите конвертирование: ");
    proverkaNaVihod = isExitString(valutaVKotoruyuConvertiruem);
    if (proverkaNaVihod == false) break;
    valutaVKotoruyuConvertiruem = ProverkaNaValutu(valutaVKotoruyuConvertiruem, koshelek);
    proverkaNaVihod = isExitString(valutaVKotoruyuConvertiruem);
    if (proverkaNaVihod == false) break;

    Console.WriteLine(); 
    Console.WriteLine($"Вы конверитруете {convertiruemayaValuta} в {valutaVKotoruyuConvertiruem} в количестве {kolichestvoKonvertiruemoyValuti}");
    
    Console.WriteLine(); 
    switch(valutaVKotoruyuConvertiruem.ToLower())
    {
        case "рубли":
            kolichestvoKonvertiruemoyValuti = Convertirovanie(convertiruemayaValuta, kolichestvoKonvertiruemoyValuti);
            rubli += kolichestvoKonvertiruemoyValuti;
            Console.WriteLine($"Итого у вас: {rubli} рублей");
            break;

        case "доллары":
            kolichestvoKonvertiruemoyValuti = Convertirovanie(convertiruemayaValuta, kolichestvoKonvertiruemoyValuti);
            dollari += kolichestvoKonvertiruemoyValuti/60; 
            Console.WriteLine($"Итого у вас: {dollari} долларов");
            break;
    
        case "евро":
            kolichestvoKonvertiruemoyValuti = Convertirovanie(convertiruemayaValuta, kolichestvoKonvertiruemoyValuti);
            euro += kolichestvoKonvertiruemoyValuti/70;
            Console.WriteLine($"Итого у вас: {euro} евро");
            break;

        case "юани":
            kolichestvoKonvertiruemoyValuti = Convertirovanie(convertiruemayaValuta, kolichestvoKonvertiruemoyValuti);
            yuani += kolichestvoKonvertiruemoyValuti/15;
            Console.WriteLine($"Итого у вас: {yuani} юаней");
            break;

        case "фунты":
            kolichestvoKonvertiruemoyValuti = Convertirovanie(convertiruemayaValuta, kolichestvoKonvertiruemoyValuti);
            funti += kolichestvoKonvertiruemoyValuti/80;
            Console.WriteLine($"Итого у вас: {funti} фунтов");
            break;
    }        
    }                          
