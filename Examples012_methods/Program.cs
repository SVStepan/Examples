// Вид 1 - ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор Степан");
}
Method1();


// ВИД 2  что-то принимают, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "новый текст");

// Вид 3  ничего не принимают, но что-то возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int Year = Method3();
// Console.WriteLine(Year);

// Вид 4 Что-то принимают и что-то возвращают
string Method4(int count, string Text)
{
    int i = 0;
    string result = String.Empty;

    while (i<count)
    {
        result = result + Text;
        i++;
    }
    return result;
}
string res = Method4(10, "as_df");
Console.WriteLine(res);
