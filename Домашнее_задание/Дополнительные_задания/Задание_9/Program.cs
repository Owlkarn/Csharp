void AddStartDataToArrays(string[] surname, string[] name, string[] secondname, string[] post, int[] money)
{
    string[] surnames = { "Иванов", "Петров", "Смирнов", "Кузнецов", "Попов", "Васильев", "Соколов", "Михайлов", "Новиков", "Фёдоров", "Морозов", "Волков", "Алексеев", "Лебедев", "Семёнов", "Егоров", "Павлов", "Козлов", "Степанов", "Николаев", "Орлов", "Андреев", "Макаров", "Никитин", "Захаров", "Зайцев", "Соловьев", "Борисов", "Яковлев", "Григорьев" };
    string[] names = { "Артём", "Александр", "Михаил", "Максим", "Иван", "Даниил", "Дмитрий", "Кирилл", "Никита", "Егор", "Матвей", "Андрей", "Илья", "Алексей", "Роман", "Сергей", "Владислав", "Ярослав", "Тимофей", "Арсений", "Денис", "Владимир", "Павел", "Глеб", "Константин", "Богдан", "Евгений", "Николай", "Степан", "Захар" };
    string[] secondnames = { "Артёмович", "Александрович", "Михаилович", "Максимович", "Иванович", "Даниилович", "Дмитриевич", "Кириллович", "Никитич", "Георгиевич", "Матвеевич", "Андреевич", "Ильич", "Алексеевич", "Романович", "Сергеевич", "Владиславович", "Ярославович", "Тимофеевич", "Арсениевич", "Денисович", "Владимирович", "Павлович", "Глебович", "Константинович", "Богданович", "Евгениевич", "Николаевич", "Степанович", "Захарович" };
    string[] proffesion = { "Директор", "Зам. директора", "Гл. бухгалтер", "Вед. экономист", "Нач. отдела", "Ст. разработчик", "Вед. специалист", "Ст. мастер", "Вед. инженер", "Мастер", "Специалист 1 категории", "Инженер", "Специалист 2 категории", "Оператор ЭВМ", "Электрик", "Слесарь", "Токарь", "Грузчик", "Водитель", "Уборщик" };
    for (int i = 0; i < name.Length; i++)
    {
        surname[i] = surnames[new Random().Next(0, 30)];
        name[i] = names[new Random().Next(0, 30)];
        secondname[i] = secondnames[new Random().Next(0, 30)];
        post[i] = proffesion[i];
        money[i] = 1000000 - 50000 * i;
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    while (number == String.Empty)
    {
        Console.Write(message);
        number = Console.ReadLine();
    }
    return Convert.ToInt32(number);
}

void SelectionSort(string[] surname, string[] name, string[] secondname, string[] post, int[] money)
{
    for (int i = 0; i < money.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < money.Length; j++)
        {
            if (money[j] > money[maxPosition])
            {
                maxPosition = j;
            }
        }
        int temporaryMoney = money[i];
        money[i] = money[maxPosition];
        money[maxPosition] = temporaryMoney;
        string temporaryName = name[i];
        name[i] = name[maxPosition];
        name[maxPosition] = temporaryName;
        string temporarySurname = surname[i];
        surname[i] = surname[maxPosition];
        surname[maxPosition] = temporarySurname;
        string temporarySecondname = secondname[i];
        secondname[i] = secondname[maxPosition];
        secondname[maxPosition] = temporarySecondname;
        string temporaryPost = post[i];
        post[i] = post[maxPosition];
        post[maxPosition] = temporaryPost;
    }
}

string[] AddToArrayStringIn(string[] array, string newElement)
{
    string[] newArray = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    newArray[array.Length] = newElement;
    return newArray;
}

int[] AddToArrayIntIn(int[] array, int newElement)
{
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    newArray[array.Length] = newElement;
    return newArray;
}

int[] RemoveFromArrayIntIn(int[] array, int number)
{
    int[] newArray = new int[array.Length - 1];
    for (int i = 0; i < number - 1; i++)
    {
        newArray[i] = array[i];
    }
    for (int i = number; i < array.Length; i++)
    {
        newArray[i - 1] = array[i];
    }
    return newArray;
}

string[] RemoveFromArrayStringIn(string[] array, int number)
{
    string[] newArray = new string[array.Length - 1];
    for (int i = 0; i < number - 1; i++)
    {
        newArray[i] = array[i];
    }
    for (int i = number; i < array.Length; i++)
    {
        newArray[i - 1] = array[i];
    }
    return newArray;
}

int[] FilterArrayStringIn(string[] array, string search)
{
    int count = 0;
    int[] filterArray = new int[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].IndexOf(search) != -1)
        {
            count++;
            int[] tempFilterArray = new int[count];

            for (int j = 0; j < count - 1; j++)
                tempFilterArray[j] = filterArray[j];

            tempFilterArray[count - 1] = i;
            filterArray = tempFilterArray;
        }
    }
    return filterArray;
}

void PrintFilterArrayStringIn(string[] surname, string[] name, string[] secondname, string[] post, int[] money, int[] filter)
{
    string[] filterSurname = new string[filter.Length];
    string[] filterName = new string[filter.Length];
    string[] filterSecondname = new string[filter.Length];
    string[] filterPost = new string[filter.Length];
    int[] filterMoney = new int[filter.Length];

    for (int i = 0; i < filter.Length; i++)
    {
        filterMoney[i] = money[filter[i]];
        filterName[i] = name[filter[i]];
        filterPost[i] = post[filter[i]];
        filterSecondname[i] = secondname[filter[i]];
        filterSurname[i] = surname[filter[i]];
    }
    for (int i = 0; i < filter.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {filterSurname[i]} {filterName[i]} {filterSecondname[i]} {filterPost[i]} {filterMoney[i]}");
    }
}

int peopleNumber = ReadInt("Укажите количество человек, которое работает в компании в данный момент (от 1 до 20): ");
string[] lastname = new string[peopleNumber];
string[] firstname = new string[peopleNumber];
string[] middlename = new string[peopleNumber];
string[] position = new string[peopleNumber];
int[] salary = new int[peopleNumber];

AddStartDataToArrays(lastname, firstname, middlename, position, salary);

Console.WriteLine("Список команд:\n" +
"- ShowAll – показать все досье в базе\n" +
"- AddFile – добавление нового досье\n" +
"- RemoveFile -  удаление досье\n" +
"- FilterSalary – фильтр досье по зарплате\n" +
"- FilterLastname – фильтр досье по фамилии\n" +
"- FilterPosition – фильтр досье по должности\n" +
"- Exit - выход");

bool repeatProgramm = true;
while (repeatProgramm)
{
    Console.WriteLine("Введите команду: ");
    string command = Console.ReadLine();
    switch (command.ToLower())
    {
        case "showall":
            {
                for (int i = 0; i < lastname.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {lastname[i]} {firstname[i]} {middlename[i]} {position[i]} {salary[i]}");
                }
                break;
            }
        case "addfile":
            {
                Console.WriteLine("Введите фамилию работника: ");
                string addLastname = Console.ReadLine();

                if (addLastname.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    while (addLastname == String.Empty)
                    {
                        Console.WriteLine("Введите фамилию работника: ");
                        addLastname = Console.ReadLine();
                    }
                    lastname = AddToArrayStringIn(lastname, addLastname);
                }

                Console.WriteLine("Введите имя работника: ");
                string addFirstname = Console.ReadLine();

                if (addFirstname.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    while (addFirstname == String.Empty)
                    {
                        Console.WriteLine("Введите имя работника: ");
                        addFirstname = Console.ReadLine();
                    }
                    firstname = AddToArrayStringIn(firstname, addFirstname);
                }

                Console.WriteLine("Введите отчество работника: ");
                string addMiddlename = Console.ReadLine();

                if (addMiddlename.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    while (addMiddlename == String.Empty)
                    {
                        Console.WriteLine("Введите отчество работника: ");
                        addMiddlename = Console.ReadLine();
                    }
                    middlename = AddToArrayStringIn(middlename, addMiddlename);
                }

                Console.WriteLine("Введите должность работника: ");
                string addPosition = Console.ReadLine();

                if (addPosition.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    while (addPosition == String.Empty)
                    {
                        Console.WriteLine("Введите должность работника: ");
                        addPosition = Console.ReadLine();
                    }
                    position = AddToArrayStringIn(position, addPosition);
                }

                int addSalary = ReadInt("Введите зарплату работника: ");
                salary = AddToArrayIntIn(salary, addSalary);

                SelectionSort(lastname, firstname, middlename, position, salary);
                break;
            }
        case "removefile":
            {
                if (lastname.Length == 0)
                {
                    Console.WriteLine("Каталог пуст");
                    break;
                }
                else
                {
                    int delNumber = ReadInt("Введите номер досье для удаления: ");
                    lastname = RemoveFromArrayStringIn(lastname, delNumber);
                    firstname = RemoveFromArrayStringIn(firstname, delNumber);
                    middlename = RemoveFromArrayStringIn(middlename, delNumber);
                    position = RemoveFromArrayStringIn(position, delNumber);
                    salary = RemoveFromArrayIntIn(salary, delNumber);
                }
                break;
            }
        case "filtersalary":
            {
                if (salary.Length == 0)
                {
                    Console.WriteLine("Каталог пуст");
                    break;
                }
                else
                {
                    int filterMin = ReadInt($"Введите минимальное значение зарплаты в фильтре (самая низкая зарплата: {salary[salary.Length - 1]}): ");
                    if (filterMin > salary[0])
                    {
                        Console.WriteLine("Все зарплаты ниже введенного значения.");
                        break;
                    }
                    else if (filterMin < salary[salary.Length - 1])
                        filterMin = salary[salary.Length - 1];

                    int filterMax = ReadInt($"Введите максимальное значение зарплаты в фильтре (самая высокая зарплата: {salary[0]}): ");

                    while (filterMax < filterMin)
                        filterMax = ReadInt("Максимальное значение в фильтре меньше минимального. Введите новое значение: ");

                    if (filterMax > salary[0])
                        filterMax = salary[0];

                    int minI = 0;
                    while (salary[minI] >= filterMin)
                        minI++;

                    int maxI = 0;
                    while (salary[maxI] > filterMax)
                        maxI++;

                    string[] filterFirstname = new string[minI - maxI];
                    string[] filterLastname = new string[minI - maxI];
                    string[] filterMiddlename = new string[minI - maxI];
                    string[] filterPosition = new string[minI - maxI];
                    int[] filterSalary = new int[minI - maxI];

                    for (int i = 0; i < filterSalary.Length; i++)
                    {
                        filterLastname[i] = lastname[maxI];
                        filterFirstname[i] = firstname[maxI];
                        filterMiddlename[i] = middlename[maxI];
                        filterPosition[i] = position[maxI];
                        filterSalary[i] = salary[maxI];
                        maxI++;
                    }
                    for (int i = 0; i < filterSalary.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {filterLastname[i]} {filterFirstname[i]} {filterMiddlename[i]} {filterPosition[i]} {filterSalary[i]}");
                    }
                    break;
                }
            }
        case "filterlastname":
            {
                if (salary.Length == 0)
                {
                    Console.WriteLine("Каталог пуст");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите фамилию работника: ");
                    string searchLastname = Console.ReadLine();

                    while (searchLastname == String.Empty)
                    {
                        Console.WriteLine("Введите фамилию работника: ");
                        searchLastname = Console.ReadLine();
                    }

                    int[] filterLastname = FilterArrayStringIn(lastname, searchLastname);

                    PrintFilterArrayStringIn(lastname, firstname, middlename, position, salary, filterLastname);
                }
                break;
            }
        case "filterposition":
            {
                if (position.Length == 0)
                {
                    Console.WriteLine("Каталог пуст");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите должность работника: ");
                    string searchPosition = Console.ReadLine();

                    while (searchPosition == String.Empty)
                    {
                        Console.WriteLine("Введите должность работника: ");
                        searchPosition = Console.ReadLine();
                    }

                    int[] filterPosition = FilterArrayStringIn(position, searchPosition);

                    PrintFilterArrayStringIn(lastname, firstname, middlename, position, salary, filterPosition);
                }
                break;
            }
        case "exit":
            {
                repeatProgramm = false;
                break;
            }
        default:
            Console.WriteLine("Введена неверная команда. Попробуйте снова.");
            break;
    }
}