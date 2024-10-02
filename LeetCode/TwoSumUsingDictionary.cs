namespace LeetCode
{
    public class TwoSumUsingDictionary
    {
        public static int[] GetTwoSumUsingDictionary(int[] nums, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int potentialmatch = target - nums[i];

                if (result.ContainsKey(potentialmatch))
                    return [result[potentialmatch], i];
                else
                    result.Add(nums[i], i);
            }
            return [];
        }
    }
}
