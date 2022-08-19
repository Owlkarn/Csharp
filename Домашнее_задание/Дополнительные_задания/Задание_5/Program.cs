double ReadDouble(string message)
{
    Console.Write(message);
    double n = Convert.ToDouble(Console.ReadLine());
    while (n < 0)
    {
        Console.Write("Введено неверное значение, введите новое: ");
        n = Convert.ToDouble(Console.ReadLine());
    }
    return n;
}

string ReadStr(string convert)
{
    Console.Write(convert);
    return Console.ReadLine();
}

double ProverkaNaNalichie(double nado, double est)
{
    bool check = true;
    while (check)
    {
        if (nado > est)
        {
            Console.WriteLine(); 
            Console.Write("На вашем счете недостаточно средств, введите новое значение: ");
            nado = Convert.ToDouble(Console.ReadLine());
        }
        else check = false;        
    }
    return nado;
}

string ProverkaNaValutu(string v, string[] arr)
{
    bool ch = true;
    while (ch)
    {
        if (arr.Contains(v))
        {
            ch = false;
        }
        else
        {
            Console.WriteLine(); 
            Console.Write("Такой валюты у Вас нет, введите новое значение: ");
            v = Console.ReadLine();
        }
    }
    return v;
}

double Vichitanie(double val, double res)
{
    val -=res;
    return val;
}

double Convertirovanie(string v_1, double k_v)
{
switch (v_1.ToLower())
            {
                case "рубли":
                    break;

                case "доллары":
                    k_v *= 60;
                    break;

                case "евро":
                    k_v *= 70;
                    break;

                case "юани":
                    k_v *= 15;
                    break;

                case "фунты":
                    k_v *= 80;
                    break;
            }
            return k_v;
}

bool VihodString(string exit)
{
    if (exit == "exit");
    bool j = false;
    return j;
}

string[] koshelek = {"рубли", "доллары", "евро", "юани", "фунты"};
string[]  programmEnd = {"e", "x", "i", "t"};
string  val_1 = String.Empty,
        val_2 = String.Empty;
bool ex = true;

Console.WriteLine("Укажите какое количество каждой валюты у Вас имеется:");
double rub = ReadDouble("Рубли: ");
double dol = ReadDouble("Доллары: ");
double eur = ReadDouble("Евро: ");
double yun = ReadDouble("Юани: ");
double fun = ReadDouble("Фунты: ");
Console.WriteLine();        

while (true)
{
    Console.WriteLine($"Ваш баланс: \nРубли: {rub} \nДоллары: {dol} \nЕвро: {eur} \nЮани: {yun} \nФунты: {fun}");
    
    Console.WriteLine(); 
    val_1 = ReadStr("Введите конвертируемую валюту: ");
    ex = VihodString(val_1);
    if (ex == false) break;
    val_1 = ProverkaNaValutu(val_1, koshelek);
    ex = VihodString(val_1);
    if (ex == false) break;

    double kol_val = ReadDouble("Введите количество конвертируемой валюты: ");

    if (val_1.ToLower() == koshelek[0]) 
    {
        kol_val = ProverkaNaNalichie(kol_val, rub);
        rub = Vichitanie(rub, kol_val);
    }
    else if (val_1.ToLower() == koshelek[1]) 
    {
        kol_val = ProverkaNaNalichie(kol_val, dol);
        dol = Vichitanie(dol, kol_val);
    }
    else if (val_1.ToLower() == koshelek[2]) 
    {
        kol_val = ProverkaNaNalichie(kol_val, eur);
        eur = Vichitanie(eur, kol_val);
    }
    else if (val_1.ToLower() == koshelek[3]) 
    {
        kol_val = ProverkaNaNalichie(kol_val, yun);
        yun = Vichitanie(yun, kol_val);
    }
    else if (val_1.ToLower() == koshelek[4]) 
    {
        kol_val = ProverkaNaNalichie(kol_val, fun);
        fun = Vichitanie(fun, kol_val);
    }

    val_2 = ReadStr("Введите валюту, в которую производите конвертирование: ");
    ex = VihodString(val_2);
    if (ex == false) break;
    val_2 = ProverkaNaValutu(val_2, koshelek);
    ex = VihodString(val_2);
    if (ex == false) break;

    Console.WriteLine(); 
    Console.WriteLine($"Вы конверитруете {val_1} в {val_2} в количестве {kol_val}");
    
    Console.WriteLine(); 
    switch(val_2.ToLower())
    {
        case "рубли":
            kol_val = Convertirovanie(val_1, kol_val);
            rub += kol_val;
            Console.WriteLine($"Итого у вас: {rub} рублей");
            break;

        case "доллары":
            kol_val = Convertirovanie(val_1, kol_val);
            dol += kol_val/60; 
            Console.WriteLine($"Итого у вас: {dol} долларов");
            break;
    
        case "евро":
            kol_val = Convertirovanie(val_1, kol_val);
            eur += kol_val/70;
            Console.WriteLine($"Итого у вас: {eur} евро");
            break;

        case "юани":
            kol_val = Convertirovanie(val_1, kol_val);
            yun += kol_val/15;
            Console.WriteLine($"Итого у вас: {yun} юаней");
            break;

        case "фунты":
            kol_val = Convertirovanie(val_1, kol_val);
            fun += kol_val/80;
            Console.WriteLine($"Итого у вас: {fun} фунтов");
            break;
    }        
    }                          
