/*Дан текст. В нём нужно все пробелы заменить чёрточками, маленькие буквы «к»
заменить большими «К», а большие «С» заменить на маленькие «с»*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";
//Console.WriteLine(text);

string Replace(string text, char oldSimb, char newSimb)
{
    int count = text.Length;
    int i = 0;
    string result = String.Empty;
    for (i = 0; i < count; i++)
    {
        if (text[i] == oldSimb)
        {
            result = result + newSimb;
        }
        else
        {
            result = result + text[i];
        }
    }
    return (result);
}
string newText = String.Empty;
newText = Replace(text, ' ', '|');
newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);
