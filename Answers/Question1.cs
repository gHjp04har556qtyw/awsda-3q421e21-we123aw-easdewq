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
            int r = 0;
            int n = portfolios.Length;

            for (int a = 0; a < n; a++)
            {
                int j = portfolios[a];
                for (int b = a + 1; b < n; b++)
                {
                    int x = (j ^ portfolios[b]);
                    if (x > r)
                    {
                        r = x;
                        if (x == 65335) return 65335;
                    }
                }
            }

            return r;
        }
    }
}
