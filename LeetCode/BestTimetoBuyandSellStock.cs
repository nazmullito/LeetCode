namespace LeetCode
{
    public class BestTimetoBuyandSellStock
    {
        // prices = [7,1,5,3,6,4]
        // prices = [7,2,5,1,6,4]
        public static int GetProfit(int[] prices)
        {
            int profit = 0;

            for (int smallestNumberIndex = 0, nextIndex = smallestNumberIndex + 1; nextIndex < prices.Length; nextIndex++)
            {
                if (prices[smallestNumberIndex] > prices[nextIndex])
                {
                    smallestNumberIndex = nextIndex;
                }
                else
                {
                    int difference = prices[nextIndex] - prices[smallestNumberIndex];
                    if (difference > profit)
                        profit = difference;
                }
            }

            return profit;
        }
    }

    //Make First index number as smaller one and set 2nd index number as nextIndex
    //If Check smallestNumberInddex value is greate than nextIndex value and assign nextIndex to smallestNumberInddex and Increment nextIndex
    //else calculate profit based on difference is greated than profit initial value
}
