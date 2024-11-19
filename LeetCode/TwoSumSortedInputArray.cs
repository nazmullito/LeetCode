namespace LeetCode
{
    public class TwoSumSortedInputArray
    {
        // 2,7,11,15  target = 9
        public static int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                if (numbers[left] + numbers[right] > target)
                    right--;
                else if (numbers[left] + numbers[right] < target)
                    left++;
                else return [left + 1, right + 1];
            }
            return new int[2];
        }
    }
}
