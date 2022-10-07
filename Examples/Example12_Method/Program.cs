// Виды МЕТОДОВ:

// Вид 1 (аргументы НЕ принимают, ничего НЕ возвращают)

void Method1()
{
    Console.WriteLine("Автор Я");
}
// Method1();



// Вид 2 (принимают аргументы, ничего НЕ возвращают)

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");


void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method2_1("Вот этот текст", 5);
// Method2_1(count: 6, msg: "А теперь вот этот текст");



// Вид 3 (аргументы НЕ принимают, ЧТО-ТО возвращают)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);



// Вид 4 (принимают аргументы, ЧТО-ТО возвращают)

// С циклом "WHILE":

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

// string res = Method4(10, "Хей-Хо! ");
// Console.WriteLine(res);


// Теперь с циклом "FOR":

string Method4_1(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4_1(10, "Хей-Хо! ");
Console.WriteLine(res);