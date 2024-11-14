namespace LeetCode
{
    public class ContainsDuplicateTwo
    {
        //1,2,3,1,2,3
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
                else
                {
                    int PreviousDuplicateIdx = dict[nums[i]];
                    if (Math.Abs(PreviousDuplicateIdx - i) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
            }
            return false;
        }
    }
}
