using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] numOfShares, int totalValueOfShares)
        {
            // sort the array
            Array.Sort(numOfShares);

            // split the number in 2
            int estimate = totalValueOfShares;
            int found = 0;

            for(int i=0; i<numOfShares.Length; i++)
            {
                if (numOfShares[i] == estimate) found++;
            }

            return found;
        }
    }
}