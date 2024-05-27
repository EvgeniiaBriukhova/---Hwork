/* Задача 1: Задайте двумерный массив символов (тип char [,]). 
Создать строку из символов этого массива. */

string CharArrayToString(char[,] arr)
{
    string res = "";

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res += arr[i, j];
        }
    }
    return res.ToString();
}

    char[,] charArray = {
            {'A', 'B', 'C'},
            {'D', 'E', 'F'},
            {'G', 'H', 'I'}
        };


    string result = CharArrayToString(charArray);
    Console.WriteLine(result);

    