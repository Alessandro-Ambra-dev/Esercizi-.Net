public class PalindromeChecking
{
    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if (text[0] != text[text.Length - 1])
                return false;
            else
                return IsPalindrome(text.Substring(1, text.Length-2));
        }
    }

    public static void Main()
    {
        string input;
        bool check;

        Console.WriteLine("Please enter a word/text");
        input = Console.ReadLine();

        check = IsPalindrome(input);

        if (check)
        {
            Console.WriteLine($"{input} is palindrome");
        }
        else 
        {
            Console.WriteLine($"{input} is not palindrome");
        }
    }
}




