using LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        #region Check Palindrome Compare with reverse
        //Console.WriteLine("Enter Number:");
        //string number = Console.ReadLine();
        //Console.WriteLine(CheckPalindrome.IsPalindrome(number));
        #endregion

        #region Check Palindrome Compare with reverse(n(Log n))
        Console.WriteLine("Enter Number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(CheckPalindrome.IsPalindrome(number));
        #endregion
    }
}