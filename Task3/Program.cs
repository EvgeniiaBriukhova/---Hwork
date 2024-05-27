/* Задача 3: Задайте произвольную строку. Выясните, 
является ли она палиндромом. */



bool IsPalindrome(string input)
{
    int left = 0;
    int right = input.Length - 1;

    while (left < right)
    {
        if (input[left] != input[right])
        {
            return false;
        }
        left++;
        right--;
    }

    return true;
}

string input = " abba ";

bool isPalindrome = IsPalindrome(input);
Console.WriteLine(isPalindrome ? "Yes" : "No");