namespace LeetCode
{
    public class ReverseString
    {
        public static char[] GetReverseString(char[] input)
        {
            int swapCounter = input.Length / 2;

            for (int i = 0, j = input.Length - 1; i < swapCounter; i++)
            {
                char swapcharacter = input[i];
                input[i] = input[j];
                input[j] = swapcharacter;
                j--;
            }

            return input;
        }
    }
}
