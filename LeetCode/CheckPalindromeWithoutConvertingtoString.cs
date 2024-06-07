namespace LeetCode
{
    public class CheckPalindromeWithoutConvertingtoString
    {
        public static bool IsPalindrome(int number)
        {
            int original = number;
            int reverse = 0;

            if (number < 0)
                return false;

            while (number != 0)
            {
                reverse = reverse * 10 + number % 10;

                number = number / 10;
            }
            if (original == reverse)
                return true;
            else
                return false;
        }
    }
}
