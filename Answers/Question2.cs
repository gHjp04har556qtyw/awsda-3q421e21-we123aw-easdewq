using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {

        // Helper method to return the sum of an array
        public static int SumArray(int[] arr, int n)
        {
            int sum = 0;
            for(int i=0; i<n; i++)
            {
                sum += arr[i];
            }
            return sum;
        }


        public static int Answer(int[] cashflowIn, int[] cashflowOut)
        {
            int sumA = SumArray(cashflowIn, cashflowIn.Length);
            int sumB = SumArray(cashflowOut, cashflowOut.Length);


            // Dynamically add smallest positive number that also has a small negative number
            // If there is no small negative, don't use it, try other solutions until 0 is found

            return 0;
        }
    }
}