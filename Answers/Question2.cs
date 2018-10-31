using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] cashflowIn, int[] cashflowOut)
        {
            int sum1 = getSum(cashflowIn);
            int sum2 = getSum(cashflowOut);
            int len1 = cashflowIn.Length;
            int len2 = cashflowOut.Length;
            // subset sums
            List<int> inSums = isSubsetSum(cashflowIn, cashflowIn.Length, sum1);
            List<int> outSums = isSubsetSum(cashflowOut, cashflowOut.Length, sum2);
            Dictionary<int, int> _dictionary = new Dictionary<int, int>();
            foreach (var x in inSums)
            {
                _dictionary.Add(x, 1);
            }

            foreach (var z in outSums)
            {
                if (!_dictionary.ContainsKey(z))
                {
                    _dictionary.Add(z, 1);
                }
                else
                {
                    return 0;
                }
            }

            // add empty set
            _dictionary.Add(0, 1);
            // convert the dictionary to an array
            int[] arr = (new List<int>(_dictionary.Keys)).ToArray();
            // return the lowest difference in the array
            return findMinDiff(arr, arr.Length);
        }

        static int findMinDiff(int[] arr, int n)
        {
            Array.Sort(arr);
            int diff = int.MaxValue;
            for (int i = 0; i < n - 1; i++)
                if (arr[i + 1] - arr[i] < diff)
                    diff = arr[i + 1] - arr[i];
            return diff;
        }

        static int getSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        static List<int> isSubsetSum(int[] set, int n, int sum)
        {
            List<int> nums = new List<int>();
            // The value of subset[i][j] will be true if there  
            // is a subset of set[0..j-1] with sum equal to i 
            bool[,] subset = new bool[sum + 1, n + 1];
            // If sum is 0, then answer is true 
            for (int i = 0; i <= n; i++)
                subset[0, i] = true;
            // If sum is not 0 and set is empty, then answer is false 
            for (int i = 1; i <= sum; i++)
                subset[i, 0] = false;
            // Fill the subset table in botton up manner 
            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    if (i >= set[j - 1])
                        subset[i, j] = subset[i, j] || subset[i - set[j - 1], j - 1];
                }
            }

            for (int i = 1; i <= sum; i++)
            {
                if (subset[i, n])
                {
                    nums.Add(i);
                }
            }

            return nums;
        }
    }
}