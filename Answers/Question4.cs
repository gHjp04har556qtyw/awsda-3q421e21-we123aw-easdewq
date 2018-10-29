using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
            


        public static int Answer(string[,] machineToBeFixed, int numOfConsecutiveMachines)
        {
            int systemSize = machineToBeFixed.GetLength(0);
            int pcSize = machineToBeFixed.GetLength(1);

            // remove impossibilities
            if (pcSize < numOfConsecutiveMachines || systemSize <= 0 || systemSize > 100 || pcSize <= 0 || pcSize > 100 || systemSize == 0 || pcSize == 0) return 0;

            byte arrayPos = 0;
            bool canFix = false;
            int min = Int32.MaxValue, sum, val;
            int[] window = new int[numOfConsecutiveMachines];
            string pc;

            for (int i = 0; i < systemSize; i++)
            {
                arrayPos = 0;
                sum = 0;
                for (int j = 0; j < pcSize; j++)
                {
                    pc = machineToBeFixed[i, j];

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


                        // check that we can fit
                        if (arrayPos == 0)
                        {
                            var endDestination = machineToBeFixed[i, j + numOfConsecutiveMachines];
                            var midPoint = machineToBeFixed[i, j + (numOfConsecutiveMachines / 2)];

                            // go to next iteration of loop
                            if (endDestination.Length == 1 && endDestination.Equals("X")) break;
                            if (midPoint.Length == 1 && midPoint.Equals("X")) break;
                        }


                        // otherwise try normal calculations
                        val = Convert.ToInt32(pc);
                        window[arrayPos] = val;
                        sum += val;
                        if (arrayPos == numOfConsecutiveMachines - 1)
                        {
                            canFix = true;
                            if (sum < min)
                            {
                                min = sum;

                                if (sum == numOfConsecutiveMachines) return numOfConsecutiveMachines;
                            }
                            sum -= window[0];
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

            return canFix ? min : 0;
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