// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
static string CharArrToString(char[,] chars)
{
    string result = "";
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            result += chars[i, j];
        }
        result += '\n';
    }
    return result;
}


// char[,] chars = { { 'a', 'b', 'c', 'd', 'e' }, { 'f', 'g', 'h', 'i', 'j' } };

// Console.WriteLine(CharArrToString(chars));

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

static string DownCase(string str)
{
    string result = str.ToLower();
    return result;
}

// string str = "ASKJdhjnbasdi8KMSD";
// Console.WriteLine(DownCase(str));

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// 

static bool PalinDromeStr(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            return false;
        }
    }
    return true;
}

// string str = "absba";
// Console.WriteLine(PalinDromeStr(str));

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
// Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.

static string ReversStr(string str)
{
    string[] split = str.Split();
    string result = "";
    for (int i = split.Length - 1; i > 0; i--)
    {
        result = result + split[i] + " ";
    }
    result += split[0];
    return result;
}

string str = "a bs ba";
Console.WriteLine(ReversStr(str));