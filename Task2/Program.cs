/* Задача 2: Задайте строку, содержащую латинские буквы 
в обоих регистрах. Сформируйте строку, 
в которой все заглавные буквы заменены на строчные. */

string CharArrayToString(char[] arr)
{
    string res = ""; 
    foreach (char c in arr)
    {
        if (char.IsUpper(c))
        {
            res += char.ToLower(c);
        }
        else
        {
            // Добавление строчной буквы или символа без изменений
            res += c;
        }
    }
    return res;
}

char[] array = { 'A', 'b', 'C', 'D', 'e', 'f' };
string result = CharArrayToString(array);
Console.WriteLine(result); 
