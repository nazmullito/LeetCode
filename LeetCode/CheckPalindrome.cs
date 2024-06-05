namespace LeetCode
{
    public class CheckPalindrome
    {
        public static bool IsPalindrome(int number)
        {
            // 161
            // 161/10 = 16...1
            // 16/10=1...6
            // 1/10=

            int quotient = 121;
            if (quotient < 0) return false;

            int original = quotient;
            int reversed = 0;
            while (quotient != 0)
            {
                reversed = reversed * 10 + quotient % 10; // reversed = 0*10 + 121%10=0+1=1 > 1*10+12%10=10+2=12 > 12*10 + 1%10=120+1=121
                //x /= 10;
                quotient = quotient / 10; //x= 121/10 =12  > X= 12/10 =1 > 1 / 10=0
            }

            return original == reversed;


            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] != number[number.Length - 1 - i])
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
    }
}
