using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
            


        public static int Answer(string[,] machineToBeFixed, int numOfConsecutiveMachines)
        {
            int min = Int32.MaxValue;
            int systemSize = machineToBeFixed.GetLength(0);
            int pcSize = machineToBeFixed.GetLength(1);
            int[] window = new int[numOfConsecutiveMachines];

            bool canFix = false;

            int arrayPos = 0;

            // don't count if we can't
            if (pcSize < numOfConsecutiveMachines)
            {
                return 0;
            }

            int sum;
            for (int i = 0; i < systemSize; i++)
            {
                arrayPos = 0;
                sum = 0;
                for (int j = 0; j < pcSize; j++)
                {
                    string pc = machineToBeFixed[i, j];

                    if (pc.Length == 1 && pc.Equals("X"))
                    {
                        if (arrayPos != 0)
                        {
                            arrayPos = 0;
                            sum = 0;
                        }
                    }
                    else
                    {
                        int val = Convert.ToInt32(pc);
                        window[arrayPos] = val;
                        sum += val;
                        if (arrayPos == numOfConsecutiveMachines - 1)
                        {
                            canFix = true;
                            if (sum < min)
                            {
                                min = sum;
                            }
                            sum -= window[0];
                            // left shift
                            for (int p = 0; p < window.Length - 1; p++)
                            {
                                window[p] = window[p + 1];
                            }
                            arrayPos--;
                        }
                        arrayPos++;
                    }
                }
            }


            if (!canFix)
            {
                return 0;
            }
            return min;
        }

        /*
         * int min = Int32.MaxValue;
            bool canFix = false;
            int systemSize = machineToBeFixed.GetLength(0);
            int pcSize = machineToBeFixed.GetLength(1);

            // don't count if we can't
            if (pcSize < numOfConsecutiveMachines)
            {
                return 0;
            }

            int count = 0;
            int sum = 0;

            for (int i = 0; i < systemSize; i++)
            {
                count = 0;
                sum = 0;
                for (int j = 0; j < pcSize; j++)
                {
                    var pc = machineToBeFixed[i, j];
                    if (pc.Length == 1 && pc.Equals("X"))
                    {
                        count = 0;
                        sum = 0;
                    }
                    else
                    {
                        count++;
                        sum += Convert.ToInt32(pc);

                        if (count == numOfConsecutiveMachines)
                        {
                            canFix = true;
                            if (sum < min)
                            {
                                min = sum;
                            }
                            sum = 0;
                        }
                    }
                }
            }

            return canFix ? min : 0;*/

        /*   
        public static bool canFix(string[] system, int numOfConsecutiveMachines)
        {
            int n = system.Length;
            int difference = Math.Abs(n - numOfConsecutiveMachines);

            // if any of these values are X then it is impossible to fit in here!
            for (int i=difference; i < n - difference; i++)
            {
                if (system[i].Equals("X")) return false;
            }

            return true;
        }*/
    }
}