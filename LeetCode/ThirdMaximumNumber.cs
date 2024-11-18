namespace LeetCode
{
    public class ThirdMaximumNumber
    {
        //3,3,4,3,4,3,0,3,3
        // 1,1,2   >> 2
        public static int ThirdMax(int[] nums)
        {
            int max = 0;
            int secondMax = 0;
            int thirdMax = 0;

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                }
            }

            foreach (int number in set)
            {
                if (max == 0 || number > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = number;
                }
                else if (secondMax == 0 || number > secondMax)
                {
                    thirdMax = secondMax;
                    secondMax = number;
                }
                else if (thirdMax == 0 || number > thirdMax)
                {
                    thirdMax = number;
                }
            }
            if (set.Count < 3)
                return max;
            return thirdMax;
        }
    }
}