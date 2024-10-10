namespace LeetCode
{
    public class ReverseInteger
    {
        public static int GetReverseInteger(int number)
        {
            int quotiont = number;
            int remainder = 0;
            int reverseNumber = 0;
            while (quotiont != 0)
            {
                reverseNumber = (10 * reverseNumber) + quotiont % 10;

                remainder = number % 10;
                quotiont = quotiont / 10;
                number = quotiont;
                if (Math.Abs(quotiont) < 1) break;
                if (reverseNumber > int.MaxValue / 10 || reverseNumber < int.MinValue / 10)
                    return 0;
            }
            return reverseNumber;
        }
    }
}
