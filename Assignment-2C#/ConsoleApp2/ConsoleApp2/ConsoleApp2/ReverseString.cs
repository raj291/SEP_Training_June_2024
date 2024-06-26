namespace ConsoleApp2;

public class ReverseString
{
    public string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        string reversedString = "";
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversedString += input[i];
        }
        Console.WriteLine($"Input String To Reverse :");
        return reversedString;

    }

    public bool IsPalindrome(string reverseString, string input)
    {
        if (reverseString == input)
        {
            Console.WriteLine("The Input is a palindrome");
            return true;

        }
        {
            Console.WriteLine("The Input is not a palindrome");
            return false;
        }
    }
    /*public string ReverseWords(string input)
    {
        char[] charArray = input.ToCharArray();
        string ReversedSentence = "";
        string unknown = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (charArray[i] == '.' || charArray[i] == ',' || charArray[i] == ':' || charArray[i] == ';' ||
                charArray[i] == '=' || charArray[i] == '!' || charArray[i] == '/')
            {
                unknown += input[i];
                ReversedSentence = unknown;
            }
            ReversedSentence += input[i];
            }
        }*/
    
    
}