namespace LeetCode
{
    public class ValidPalindrome
    {
        #region Using Regex
        //public static bool IsPalindrome(string s)
        //{
        //    s = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty).ToLower();

        //    int start = 0;
        //    int end = s.Length - 1;
        //    bool isPalindrome = false;
        //    if (s == string.Empty)
        //    {
        //        return isPalindrome = true;
        //    }
        //    while (start <= end)
        //    {
        //        if (s[start] == s[end])
        //        {
        //            isPalindrome = true;
        //        }
        //        else
        //        {
        //            isPalindrome = false;
        //            break;
        //        }
        //        start++;
        //        end--;
        //    }

        //    return isPalindrome;
        //}
        #endregion

        #region better approach
        public static bool IsPalindrome(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            s = s.ToLower();

            while (left < right)
            {
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        #endregion
    }
}
