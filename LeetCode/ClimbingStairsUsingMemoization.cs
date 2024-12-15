namespace LeetCode
{
    public class ClimbingStairsUsingMemoization
    {
        public int ClimbStairs(int n)
        {
            int[] ways = new int[n + 1];
            Array.Fill(ways, -1);
            return CountWays(n, ways);
        }

        public static int CountWays(int n, int[] ways)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;

            if (ways[n] != -1)
                return ways[n];

            return ways[n] = CountWays(n - 1, ways) + CountWays(n - 2, ways);
        }
    }
}
