// Вывести таблицу умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

string text = "Утром, когда свет из столовой через приоткрытую дверь виднеется еще только бледной щелкой,";
            // + "я знаю, что у самой двери в темноте сидит и дожидается меня кот Васька. Он, наверное, боится пропустить"
            // + "мой вход в столовую.";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newtext = Replace(text, " ", "|");
Console.WriteLine(newtext);