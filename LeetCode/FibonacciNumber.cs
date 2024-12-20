﻿namespace LeetCode
{
    public class FibonacciNumber
    {
        public static int GetFibonacciNumber(int n)
        {
            //** Linear time complexity O(n) using dynamic programming.
            if (n == 0) return 0;
            if (n == 1) return 1;
            int a = 0;
            int b = 1;
            int sum = a + b;

            while (n > 1)
            {
                sum = a + b;
                a = b;
                b = sum;
                n--;
            }
            return sum;
        }
    }
}
