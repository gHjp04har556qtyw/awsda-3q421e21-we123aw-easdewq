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

            // impossibilities
            if (n < 2 || n > 100) return 0;

            for (int i = 0; i < n; i++)
            {
                int subA = portfolios[i];
                for (int j = i + 1; j < n; j++)
                {
                    int XOR = (subA ^ portfolios[j]);
                    if (XOR > r)
                    {
                        r = XOR;
                        if (XOR == 65335) return 65335;
                    }
                }
            }

            return r;
        }
    }
}
