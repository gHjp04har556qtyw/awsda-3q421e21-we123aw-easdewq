using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] numOfShares, int totalValueOfShares)
        {
            int len = numOfShares.Length;

            // only one way to split this
            if (len == 2 && (totalValueOfShares/2) > 0) return 2;

            // try the normal splitting


            // no way to split
            return 0;
        }
    }
}