
public class PalindromeSentence
{
    public static string FindAndSortPalindromes(string text)
    {
        List<string> palindromes = new List<string>();

        string[] words = text.Split(new char[] { ' ', ',', '.', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word.ToLower());
            }
        }

        palindromes = palindromes.Distinct().ToList();
        palindromes.Sort();

        return string.Join(", ", palindromes);
    }

    private static bool IsPalindrome(string str)
    {
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(str[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(str[right]))
            {
                right--;
            }

            if (char.ToLower(str[left]) != char.ToLower(str[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}