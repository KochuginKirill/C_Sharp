string Replace(string text, char oldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int index = 0; index < length; index++)
    {
        if(text[index] == oldValue) result = result + $"{NewValue}";
        else result = result + $"{text[index]}";
    }
    return result;
}

string NewText = Replace("qweqwe",'q','d');
Console.Write(NewText);