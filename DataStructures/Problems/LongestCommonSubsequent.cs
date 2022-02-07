using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    public class LongestCommonSubsequent
    {
        public  int commonChild(string s1, string s2)
        {
            int[,] arr = new int[s1.Length + 1, s2.Length + 1];

            for (int i = 0; i <= s1.Length; i++)
            {
                for (int j = 0; j <= s2.Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        if (s1[i - 1] == s2[j - 1])
                        {
                            arr[i, j] = 1 + arr[i - 1, j - 1];
                        }
                        else
                        {
                            arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                        }
                    }

                   
                }
            }
            return arr[s1.Length, s2.Length];
        }
    }
}
