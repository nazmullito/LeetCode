namespace LeetCode
{
    public class CheckPalindromeWithoutConvertingtoString
    {
        public static bool IsPalindrome(int number)
        {
            //int original = number;
            //int reverse = 0;

            //if (number < 0)
            //    return false;

            //while (number != 0)
            //{
            //    reverse = reverse * 10 + number % 10;

            //    number = number / 10;
            //}
            //if (original == reverse)
            //    return true;
            //else
            //    return false; 
            int original = number;
            string reversenumber = string.Empty;
            while (number != 0)
            {
                int remainder = number % 10;
                number = number / 10;

                reversenumber = reversenumber + remainder;
            }

            if (original.ToString() == reversenumber)
                return true;
            else
                return false;
        }
    }
}
