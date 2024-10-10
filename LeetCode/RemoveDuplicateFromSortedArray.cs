namespace LeetCode
{
    public class RemoveDuplicateFromSortedArray
    {
        public static int GetUniqueCountByRemoveDuplicateFromSortedArray(int[] arr)
        {
            //1, 2, 2, 3, 4, 4, 4, 5, 5
            //1, 1, 2, 3, 4, 4, 4, 5, 5
            int idx = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] != arr[i])
                {
                    arr[idx] = arr[i];
                    idx++;
                }
            }
            return idx;
        }
    }
}
