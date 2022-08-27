double ConvertCurrency(string valuta, double perevodVValutu)
{
    switch (valuta.ToLower()) {
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

double GetCheckedCurrency(double nadoValuti, double estValuti)
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

string ProverkaNaValutu(string currency, string[] currencyList)
{
    bool proverka = true;
    while (proverka)
    {
        if (currencyList.Contains(currency))
        {
            proverka = false;
        }
        else
        {
            Console.WriteLine(); 
            Console.Write("Такой валюты у Вас нет, введите новое значение: ");
            currency = Console.ReadLine();
        }
    }
    return currency;
}

double Vichitanie(double ostatok, double vichitaemoe)
{    
    return ostatok - vichitaemoe;
}

bool IsExitString(string exit)
{
    return exit == "exit";
}

string[] koshelek = {"рубли", "доллары", "евро", "юани", "фунты"};
string[]  programmEnd = {"e", "x", "i", "t"};
string  currency = String.Empty,
        convertedCurrency = String.Empty;
bool isExit = true;

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
    currency = ReadStr("Введите конвертируемую валюту: ");
    isExit = IsExitString(currency);
    if (isExit) break;
    currency = ProverkaNaValutu(currency, koshelek);
    isExit = IsExitString(currency);
    if (isExit) break;

    double convertingCurrency = ReadDouble("Введите количество конвертируемой валюты: ");

    switch (Array.IndexOf(koshelek, currency.ToLower())) {
      case 0: convertingCurrency = GetCheckedCurrency(convertingCurrency, rubli);
        rubli = Vichitanie(rubli, convertingCurrency);
        break;
      case 1:  convertingCurrency = GetCheckedCurrency(convertingCurrency, dollari);
        dollari = Vichitanie(dollari, convertingCurrency);
        break;
      case 2: convertingCurrency = GetCheckedCurrency(convertingCurrency, euro);
        euro = Vichitanie(euro, convertingCurrency);
        break;
     case 3: convertingCurrency = GetCheckedCurrency(convertingCurrency, yuani);
        yuani = Vichitanie(yuani, convertingCurrency);
        break;
     case 4: convertingCurrency = GetCheckedCurrency(convertingCurrency, funti);
        funti = Vichitanie(funti, convertingCurrency);
        break;   
    }

    convertedCurrency = ReadStr("Введите валюту, в которую производите конвертирование: ");
    isExit = IsExitString(convertedCurrency);
    if (isExit) break;
    convertedCurrency = ProverkaNaValutu(convertedCurrency, koshelek);
    isExit = IsExitString(convertedCurrency);
    if (isExit) break;

    Console.WriteLine(); 
    Console.WriteLine($"Вы конверитруете {currency} в {convertedCurrency} в количестве {convertingCurrency}");
    
    Console.WriteLine(); 
    switch(convertedCurrency.ToLower())
    {
        case "рубли":
            convertingCurrency = ConvertCurrency(currency, convertingCurrency);
            rubli += convertingCurrency;
            Console.WriteLine($"Итого у вас: {rubli} рублей");
            break;

        case "доллары":
            convertingCurrency = ConvertCurrency(currency, convertingCurrency);
            dollari += convertingCurrency/60; 
            Console.WriteLine($"Итого у вас: {dollari} долларов");
            break;
    
        case "евро":
            convertingCurrency = ConvertCurrency(currency, convertingCurrency);
            euro += convertingCurrency/70;
            Console.WriteLine($"Итого у вас: {euro} евро");
            break;

        case "юани":
            convertingCurrency = ConvertCurrency(currency, convertingCurrency);
            yuani += convertingCurrency/15;
            Console.WriteLine($"Итого у вас: {yuani} юаней");
            break;

        case "фунты":
            convertingCurrency = ConvertCurrency(currency, convertingCurrency);
            funti += convertingCurrency/80;
            Console.WriteLine($"Итого у вас: {funti} фунтов");
            break;
    }        
    }                          
