namespace LeetCode
{
    public class CheckDuplicate
    {
        //1,2,3,1
        //1,2,3,4
        //public static bool ContainsDuplicate(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i + 1; j < nums.Length; j++)
        //        {
        //            if (nums[i] == nums[j])
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        public static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dict = [];
            int count = 1;

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                    if (count == nums.Length)
                        return false;
                    count++;
                }
            }
            return true;
        }

    }
}
