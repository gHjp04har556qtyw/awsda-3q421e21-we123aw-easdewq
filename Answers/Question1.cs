﻿using System;
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
            for (int n = portfolios.Length - 1; n >= 0; n--)
            {
                for (int j = 1; j < n; j++)
                {
                    int x = portfolios[n] ^ portfolios[j];
                    result = (x) > result ? (x) : result;
                    if (result == 65335) return 65335;
                }
            }
            return result;
        }
    }
}
