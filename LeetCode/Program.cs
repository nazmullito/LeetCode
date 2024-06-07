using LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        #region Check Palindrome O(n)
        //Console.WriteLine("Enter Number:");
        //string number = Console.ReadLine();
        //Console.WriteLine(CheckPalindrome.IsPalindrome(number));
        #endregion

        #region Check Palindrome Without Converting to String O(n)
        Console.WriteLine("Enter Number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CheckPalindromeWithoutConvertingtoString.IsPalindrome(number));
        #endregion
    }
}