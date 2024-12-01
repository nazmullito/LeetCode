namespace LeetCode
{
    public class RotateArray
    {
        //1,2,3,4,5,6,7   -- 5,6,7,1,2,3,4
        //7,6,5,4,3,2,1 rev1
        //5,6,7,4,3,2,1 rev2
        //5,6,7,1,2,3,4 rev3
        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            Reverse(nums, 0, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);
        }

        private static void Reverse(int[] nums, int start, int end)
        {
            while (start <= end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++; end--;
            }
        }
    }
}
