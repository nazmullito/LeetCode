namespace LeetCode
{
    public class MaximumPointsObtainFromCards
    {
        public static int GetMaximumPointsObtainFromCards(int[] cardPoints, int k)
        {
            // 6,2,3,4,7,2,1,7,1   k=4
            int leftSum = 0;
            int rightSum = 0;
            int maxSum = 0;
            for (int i = 0; i <= k - 1; i++)
            {
                leftSum = leftSum + cardPoints[i];
                maxSum = leftSum;
            }
            int rightIndex = cardPoints.Length - 1;

            for (int i = k - 1; i >= 0; i--)
            {
                leftSum = leftSum - cardPoints[i];
                rightSum = rightSum + cardPoints[rightIndex];
                rightIndex = rightIndex - 1;

                if (maxSum < leftSum + rightSum)
                    maxSum = leftSum + rightSum;
            }

            return maxSum;
        }
    }
}
