﻿using LeetCode;

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
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        //var totalUniqueNumber = RemoveDuplicateFromSortedArray.GetUniqueCountByRemoveDuplicateFromSortedArray(inputNumbers);
        //for (int i = 0; i < totalUniqueNumber; i++)
        //{
        //    Console.WriteLine(inputNumbers[i] + " ");
        //}
        #endregion

        #region 80. Remove Duplicates from Sorted Array II
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        //var totalUniqueNumber = RemoveDuplicateFromSortedArrayV2.GetLengthOfArrayByRemoveDuplicateFromSortedArray(inputNumbers);
        //for (int i = 0; i < totalUniqueNumber; i++)
        //{
        //    Console.WriteLine(inputNumbers[i] + " ");
        //}
        #endregion

        #region 27. Remove Element
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        //int inputValue = Convert.ToInt32(Console.ReadLine());
        //var totalUniqueNumber = RemoveElement.GetRemoveElement(inputNumbers, inputValue);
        //for (int i = 0; i < totalUniqueNumber; i++)
        //{
        //    Console.WriteLine(inputNumbers[i] + " ");
        //}
        #endregion

        #region 509. Fibonacci Number
        //Console.WriteLine("Enter position to get Fibonacci Number");
        //int inputValue = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(FibonacciNumber.GetFibonacciNumber(inputValue));
        #endregion

        #region 1423. Maximum Points You Can Obtain from Cards
        //Console.WriteLine("Enter array elements seperated by comma");
        //int[] cardPoints = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        //int numberofCards = Convert.ToInt32(Console.ReadLine());
        //int maximumPoints = MaximumPointsObtainFromCards.GetMaximumPointsObtainFromCards(cardPoints, numberofCards);
        //Console.WriteLine(maximumPoints);

        #endregion

        #region 3. Longest Substring Without Repeating Characters
        //Console.WriteLine("Enter string");
        //string word = Console.ReadLine()!;
        //int longestUniqueSubstrLength = LongestSubstringWithoutRepeatingCharacters.LengthOfLongestSubstring(word);
        //Console.WriteLine(longestUniqueSubstrLength);
        #endregion

        #region 217. Contains Duplicate
        //Console.WriteLine("Enter array elements seperated by space");
        //int[] inputNumbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        //bool isDuplicate = CheckDuplicate.ContainsDuplicate(inputNumbers);
        //Console.WriteLine(isDuplicate);
        ////int DuplicateNumber = CheckDuplicate.ReturnDuplicate(inputNumbers);
        ////Console.WriteLine(DuplicateNumber);
        #endregion

        #region 219. Contains Duplicate II
        //Console.WriteLine("Enter array elements seperated by comma");
        //int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        //int intvalue = Convert.ToInt32(Console.ReadLine());
        //bool isDuplicate = ContainsDuplicateTwo.ContainsNearbyDuplicate(numbers, intvalue);
        //Console.WriteLine(isDuplicate);
        #endregion

        #region 128. Longest Consecutive Sequence
        Console.WriteLine("Enter array elements seperated by comma");
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(","), Convert.ToInt32);
        int longestConsecutiveNumber = LongestConsecutiveSequence.LongestConsecutive(numbers);
        Console.WriteLine(longestConsecutiveNumber);
        #endregion

    }
}

