namespace LeetCode
{
    public class RemoveDuplicateFromSortedArrayV2
    {
        public static int GetLengthOfArrayByRemoveDuplicateFromSortedArray(int[] nums)
        {
            // 0,0,1,1,1,1,2,3,3      >>>>0,0,1,1,2,3,3
            // 0,0,1,1,1,1,2,2,2,3    >>>>0,0,1,1,2,2,3
            // 1,1,1,2,2,3            >>>>1,1,2,2,3

            //int i = 0;
            //int idx = 0;
            //for (i = 0; i < nums.Length; i++)
            //{
            //    if (i < 2 || nums[i] != nums[i - 2])
            //    {
            //        nums[idx] = nums[i];
            //        idx++;
            //    }
            //}
            //return idx;

            int i = 0;
            foreach (int x in nums)
            {
                if (i < 2 || x != nums[i - 2])
                {
                    nums[i] = x;
                    i++;
                }
            }
            return i;
        }
    }
}
