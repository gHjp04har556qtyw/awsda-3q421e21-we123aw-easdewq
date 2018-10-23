using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] numOfShares, int totalValueOfShares)
        {

            int highest = 0;
            // Find the lowest number 
            for(int i=0; i< numOfShares.Length; i++)
            {
                if(numOfShares[i] > highest)
                {
                    highest = numOfShares[i];
                }
            }

            int difference = Math.Abs(highest - totalValueOfShares);

            // now find the common factor between the both

            return difference;
        }
    }
}