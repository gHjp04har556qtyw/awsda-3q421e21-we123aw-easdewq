using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] numOfShares, int totalValueOfShares)
        {
            
            int n = numOfShares.Length;

            bool changed = false;
            int currAlloc = 0, minAlloc = n + 1;

            int start = 0, end = 0;
            while (end < n)
            {
                while (currAlloc <= totalValueOfShares && end < n)
                    currAlloc += numOfShares[end++];
                while (currAlloc >= totalValueOfShares && start < n)
                {
                    if (end - start < minAlloc)
                    {
                        minAlloc = end - start;
                        changed = true;
                    }
                    currAlloc -= numOfShares[start++];
                }
            }
            return changed ? minAlloc : 0;
        }
    }
}