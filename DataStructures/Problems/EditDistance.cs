using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    public class EditDistance
    {
        public int Memoize(string s1, string s2, int len1, int len2)
        {
            int[,] dp = new int[len1+1, len2+1];

            for (int i = 0; i <= len1; i++)
            {
                for (int j = 0; j <= len2; j++)
                {
                    if(i==0)
                        dp[i, j] = j;

                    else if (j == 0)
                        dp[i, j] = i;

                    else if (s1[i - 1] == s2[j - 1])
                        dp[i, j] = dp[i - 1, j - 1];

                    else
                        dp[i, j] = 1 + Math.Min(dp[i, j - 1],
                                               Math.Min(
                                                   dp[i - 1, j],
                                                   dp[i - 1, j - 1]
                                                 )
                                               );
                }
            }
            return dp[len1, len2];
        }
    }
}
