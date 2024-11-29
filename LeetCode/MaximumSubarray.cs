namespace LeetCode
{
    public class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            // -2,1,-3,4,-1,2,1,-5,4
            #region Brute Force
            //int maxSum = int.MinValue;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int sum = 0;
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        sum += nums[j];

            //        if (sum > maxSum) maxSum = sum;
            //    }
            //}
            //return maxSum;
            #endregion

            #region Optimal approach using Kadane’s Algorithm

            int maxSum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if (maxSum < sum) maxSum = sum;

                if (sum < 0) sum = 0;
            }
            return maxSum;
            #endregion
        }
    }
}
