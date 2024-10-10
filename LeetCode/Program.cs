using LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        #region Check Palindrome O(n)
        //Console.WriteLine("Enter Number:");
        //string number = Console.ReadLine();
        //Console.WriteLine(CheckPalindrome.IsPalindrome(number));
        #endregion

        #region Check Palindrome Without Converting to String O(n)
        //Console.WriteLine("Enter Number:");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(CheckPalindromeWithoutConvertingtoString.IsPalindrome(number));
        #endregion

        #region 1.Two Sum
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputnumbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), Convert.ToInt32);
        //Console.WriteLine("Enter target");
        //int target = Convert.ToInt32(Console.ReadLine());
        //var elements = TwoSumUsingDictionary.GetTwoSumUsingDictionary(inputnumbers, target);

        //Console.WriteLine("Two number of target sum is: ");
        //foreach (int element in elements)
        //{
        //    Console.WriteLine(element);
        //}
        #endregion

        #region 121. Best Time to Buy and Sell Stock
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputnumbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), Convert.ToInt32);
        //var profit = BestTimetoBuyandSellStock.GetProfit(inputnumbers);
        //Console.WriteLine(profit);
        #endregion

        #region 1991. Find the Middle Index in Array
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(" "), Convert.ToInt32);
        //var middleIndex = FindMiddleIndexInArray.FindMiddleIndex(inputNumbers);
        //Console.WriteLine(middleIndex);
        #endregion

        #region 344. Reverse String
        //Console.WriteLine("Enter string for reverse");
        //char[] input = Console.ReadLine()!.ToCharArray();
        //var reversestring = ReverseString.GetReverseString(input);
        //Console.WriteLine(reversestring);
        #endregion

        #region 7.Reverse Integer
        //Console.Write("Enter a Integer Number");
        //Console.ReadLine();
        //var inputNo = Convert.ToInt32(Console.ReadLine());
        //int reverseNumber = ReverseInteger.GetReverseInteger(inputNo);
        //Console.WriteLine(reverseNumber);
        #endregion

        #region 26. Remove Duplicates from Sorted Array
        Console.WriteLine("Enter array elements seperated by space");
        int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        var totalUniqueNumber = RemoveDuplicateFromSortedArray.GetUniqueCountByRemoveDuplicateFromSortedArray(inputNumbers);
        for (int i = 0; i < totalUniqueNumber; i++)
        {
            Console.WriteLine(inputNumbers[i] + " ");
        }
        #endregion
    }
}

