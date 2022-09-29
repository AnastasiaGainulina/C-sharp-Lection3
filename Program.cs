// вид 1 ничего не принимают, ничего не возвращают

void Method1()
{
    System.Console.WriteLine("Автор Гайнулина Анастасия");
    }
// Method1(); - так вызываем этот метод


// вид 2 что-то принимает, ничего не возвращает

void Method2 (string msg)
{
    System.Console.WriteLine(msg);
}
// Method2(msg: "Какой-то текс"); - так вызываем этот метод


void Method21 (string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Какой-то текс", 4); - так вызываем этот метод

// Именованные аргументы необязательно писать по порядку
// Method21(count: 4, msg: "Сложный текст"); - так вызываем этот метод



// Вид 3 Ничего не принимают, что-то возвращают

int Method3 ()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// System.Console.WriteLine(year);- так вызываем этот метод


// Вид 4 что-то принимают, что-то возвращают

string Method4(int count, string text)
{
int i = 0;
string result =String.Empty;

while ( i < count )
{
    result = result + text;
    i++;
}
    return result;
}

string res = Method4 (10, "z");
System.Console.WriteLine(res);