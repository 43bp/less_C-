// Дан текст
// В тексте заменить все пробелы черточками
// Маленькие "к" заменить большими "К"
// Большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласе прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s [3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|'); // в одинарные кавычки заключаются char (символы)
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К'); // в одинарные кавычки заключаются char (символы)
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'С', 'с'); // в одинарные кавычки заключаются char (символы)
Console.WriteLine(newText);