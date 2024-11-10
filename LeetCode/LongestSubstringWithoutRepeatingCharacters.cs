namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        //abcabcbb
        //public static int LengthOfLongestSubstringBruteForce(string s)
        //{
        //    int maxLegth = 0;
        //    int strLength = s.Length;

        //    for (int i = 0; i < strLength; i++)
        //    {
        //        bool[] isRepeting = new bool[256];
        //        int length = 0;
        //        for (int j = i; j < strLength; j++)
        //        {
        //            if (isRepeting[s[j]] == true)
        //            {
        //                isRepeting[s[j]] = false;
        //                break;
        //            }
        //            else
        //            {
        //                isRepeting[s[j]] = true;
        //                length++;
        //                if (maxLegth < length)
        //                    maxLegth = length;
        //            }
        //        }
        //    }
        //    return maxLegth;
        //}

        //Time complexity O(n)
        public static int LengthOfLongestSubstring(string s)
        {
            int left = 0;
            int right = 0;
            int maxLegth = 0;
            HashSet<char> charsSet = [];

            while (right < s.Length)
            {
                if (!charsSet.Contains(s[right]))
                {
                    charsSet.Add(s[right]);
                    right++;
                    maxLegth = Math.Max(maxLegth, right - left);
                }
                else
                {
                    charsSet.Remove(s[left]);
                    left++;
                }
            }
            return maxLegth;
        }
    }
}
