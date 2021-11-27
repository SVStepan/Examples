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


// string Method4(int count, string Text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i<count)
//     {
//         result = result + Text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "as_df");
// Console.WriteLine(res);



// string Method4(int count, string Text)
// {
//        string result = String.Empty;
//     for (int i = 0; i<count; i++)
//         {
//         result = result + Text;
        
//     }
//     return result;
// }
// string res = Method4(10, "as_df");
// // Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// ==== Работа с текстом
//дан текст, в тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить на маленькие "с".

// Яснали задача?

string text = "-Я думаю, - сказал князь, улыбаясь, -что, "
            + "ежели бы вас послали вместо нашегомилого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             01234
// s[3] // r

string Replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i< length; i++)
    {
        if(text[i] == oldValue) result = result+ $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replase(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText, 'В', 'в');
Console.WriteLine(newText);

