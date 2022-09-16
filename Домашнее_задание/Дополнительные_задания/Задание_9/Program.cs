void PrintArray(int[] array)
{
    Console.Write("Текущий массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

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
    return Convert.ToInt32(Console.ReadLine());
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

string[] AddToArrayString(string[] array, string newElement)
{
    string[] newArray = new string[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    newArray[array.Length] = newElement;
    return newArray;
}

int[] AddToArrayInt(int[] array, int newElement)
{
    int[] newArray = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
        newArray[i] = array[i];
    newArray[array.Length] = newElement;
    return newArray;
}

int[] RemoveFromArrayInt(int[] array, int number)
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

string[] RemoveFromArrayString(string[] array, int number)
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
                    lastname = AddToArrayString(lastname, addLastname);
                }

                Console.WriteLine("Введите имя работника: ");
                string addFirstname = Console.ReadLine();

                if (addFirstname.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    firstname = AddToArrayString(firstname, addFirstname);
                }

                Console.WriteLine("Введите отчество работника: ");
                string addMiddlename = Console.ReadLine();

                if (addMiddlename.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    middlename = AddToArrayString(middlename, addMiddlename);
                }

                Console.WriteLine("Введите должность работника: ");
                string addPosition = Console.ReadLine();

                if (addPosition.ToLower() == "exit")
                    repeatProgramm = false;

                else
                {
                    position = AddToArrayString(position, addPosition);
                }

                int addSalary = ReadInt("Введите зарплату работника: ");
                salary = AddToArrayInt(salary, addSalary);

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
                    lastname = RemoveFromArrayString(lastname, delNumber);
                    firstname = RemoveFromArrayString(firstname, delNumber);
                    middlename = RemoveFromArrayString(middlename, delNumber);
                    position = RemoveFromArrayString(position, delNumber);
                    salary = RemoveFromArrayInt(salary, delNumber);
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
                    while (salary[maxI] >= filterMax)
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
                    int count = 0;
                    string[] filterLastname = new string[0];
                    string[] filterFirstname = new string[0];
                    string[] filterMiddlename = new string[0];
                    string[] filterPosition = new string[0];
                    int[] filterSalary = new int[0];

                    for (int i = 0; i < lastname.Length; i++)
                    {
                        if (lastname[i].IndexOf(searchLastname) != -1)
                        {
                            count++;
                            string[] tempFilterLastname = new string[count];
                            string[] tempFilterFirstname = new string[count];
                            string[] tempFilterMiddlename = new string[count];
                            string[] tempFilterPosition = new string[count];
                            int[] tempFilterSalary = new int[count];

                            for (int j = 0; j < count - 1; j++)
                            {
                                tempFilterLastname[j] = filterLastname[j];
                                tempFilterFirstname[j] = filterFirstname[j];
                                tempFilterMiddlename[j] = filterMiddlename[j];
                                tempFilterPosition[j] = filterPosition[j];
                                tempFilterSalary[j] = filterSalary[j];
                            }

                            tempFilterLastname[count - 1] = lastname[i];
                            tempFilterFirstname[count - 1] = firstname[i];
                            tempFilterMiddlename[count - 1] = middlename[i];
                            tempFilterPosition[count - 1] = position[i];
                            tempFilterSalary[count - 1] = salary[i];
                            filterLastname = tempFilterLastname;
                            filterFirstname = tempFilterFirstname;
                            filterMiddlename = tempFilterMiddlename;
                            filterPosition = tempFilterPosition;
                            filterSalary = tempFilterSalary;
                        }
                    }

                    for (int i = 0; i < filterSalary.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {filterLastname[i]} {filterFirstname[i]} {filterMiddlename[i]} {filterPosition[i]} {filterSalary[i]}");
                    }
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