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
            ushort r = ushort.MinValue;
            int n = portfolios.Length;

            for (int i = 0; i < n; i++)
            {
                ushort j = (ushort)portfolios[i];
                for (int ii = i + 1; ii < n; ii++)
                {
                    ushort x = (ushort)(j ^ portfolios[ii]);
                    if (x > r)
                    {
                        if (x == 65335) return 65335;
                        r = x;
                    }
                }
            }

            return (int)r;
        }
    }
}
