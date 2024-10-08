namespace LeetCode
{
    public class FindMiddleIndexInArray
    {
        public static int FindMiddleIndex(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int leftsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int rightsum = sum - leftsum - nums[i];
                if (leftsum == rightsum)
                    return i;
                leftsum += nums[i];
            }
            return -1;
        }
    }
}


//2 3 -1 8 4 = 16
//2 3  1 8 4 = 17
