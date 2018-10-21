using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        
        public static int Answer(int[] portfolios)
        {
            
            int result = 0;
            for (int i = 0, n = portfolios.Length; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int xor = portfolios[i] ^ portfolios[j];
                    result = xor > result ? xor : result;
                }
            }
            return result;


            //if (portfolios[i] == portfolios[j]) continue;

            /*
            int result = 0;
            int n = portfolios.Length;

            // are all the array values equal?
            if (portfolios[0] == portfolios[n - 1])
            {
                for (long i = 0; i < n - 1; i++)
                {
                    if (portfolios[i] != portfolios[i + 1]) break;
                    if (i == n - 2) return 0;
                }
            }

            for (long i = 0; i < n; i++)
            {
                for (long j = i; j < n; j++)
                {
                    // two numbers are the same, skip
                    if (portfolios[i] == portfolios[j]) continue;

                    int xor = portfolios[i] ^ portfolios[j];

                    // maximum value was achieved, no need to keep checking
                    if (xor == 65535) return xor;

                    result = xor > result ? xor : result;
                }
            }
            return result;
            */
            //return -1;
        }
    }
}
