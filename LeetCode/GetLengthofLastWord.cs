namespace LeetCode
{
    public class GetLengthofLastWord
    {
        public static int LengthOfLastWord(string s)
        {
            char[] chars = s.ToCharArray();
            int lastWordLength = 0;
            if (chars.Length == 1)
            {
                return lastWordLength = 1;
            }
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                if (lastWordLength == 0 && char.IsWhiteSpace(chars[i]))
                    continue;
                if (lastWordLength != 0 && char.IsWhiteSpace(chars[i]))
                    break;
                lastWordLength++;
            }
            return lastWordLength;
        }
    }
}
