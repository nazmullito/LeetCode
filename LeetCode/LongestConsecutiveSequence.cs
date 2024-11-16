
namespace LeetCode
{
    public class LongestConsecutiveSequence
    {
        // 100,4,200,1,3,2
        // 102,4,100,1,101,3,2,1,1
        #region Brute force approach
        //public static int LongestConsecutive(int[] nums)
        //{
        //    if (nums.Length == 0) return 0;
        //    int longest = 1;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int x = nums[i];
        //        int count = 1;

        //        while (LinearSearch(nums, x + 1) == true)
        //        {
        //            x = x + 1;
        //            count++;
        //        }
        //        if (longest < count)
        //            longest = count;
        //    }
        //    return longest;
        //}

        //private static bool LinearSearch(int[] nums, int m)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (nums[i] == m)
        //            return true;
        //    }
        //    return false;
        //}
        #endregion

        #region Optimal approach O(n)
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            int maxConsecutive = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }

            foreach (int number in set)
            {
                if (!set.Contains(number - 1))
                {
                    int x = number;
                    int count = 1;
                    while (set.Contains(x + 1))
                    {
                        x = x + 1;
                        count = count + 1;
                    }
                    if (maxConsecutive < count)
                        maxConsecutive = count;
                }
            }

            return maxConsecutive;
        }
        #endregion

    }
}
