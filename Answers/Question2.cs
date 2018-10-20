using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] cashflowIn, int[] cashflowOut)
        {
            /*
            // Merge arrays into one
            int[] merged = new int[cashflowIn.Length + cashflowOut.Length];

            // Fill first half with cashflowIn
            for(int i=0; i<cashflowIn.Length; i++)
            {
                merged[i] = cashflowIn[i];
            }

            // Fill second half with cashflowOut but make them negative
            for(int i=cashflowIn.Length; i<cashflowOut.Length; i++)
            {
                merged[i] = -cashflowOut[i];
            }

            // Sort the array
            //Array.Sort(merged);


            // output merged values
            for(int i=0; i<merged.Length; i++)
            {
                Console.WriteLine(merged[i]);
            }
            */

            // Dynamically add smallest positive number that also has a small negative number
            // If there is no small negative, don't use it, try other solutions until 0 is found

            //TODO: Please work out the solution;
            return 0;
        }
    }
}