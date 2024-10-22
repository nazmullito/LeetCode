namespace LeetCode
{
    public class RemoveElement
    {
        public static int GetRemoveElement(int[] nums, int val)
        {
            // Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
            // Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]

            int idx = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[idx] = nums[i];
                    idx++;
                }
            }
            return idx;
        }
    }
}
