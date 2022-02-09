using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    public static class ClosestPair
    {
        

        public static (int x, int y) FindClosestPair(int[] arr1, int[] arr2, int target)
        {

            arr1 = arr1.OrderBy(x => x).ToArray();
            arr2 = arr2.OrderBy(x => x).ToArray();

            var closestpair = (arr1[0], arr2[0]);
            int current_diff = 0, small_diff = Math.Abs(arr1[0] + arr2[0] - target);

            int i = 0, j = arr2.Length - 1;
            
            while(i<arr1.Length && j >= 0)
            {
                current_diff = arr1[i] + arr2[j] - target;

                if(Math.Abs(current_diff) < small_diff)
                {
                    small_diff = Math.Abs(current_diff);
                    closestpair = (arr1[i], arr2[j]);
                }


                if(current_diff == 0)
                {
                    return closestpair;
                }
                else if(current_diff < 0)
                {
                    i++;
                }
                else
                {

                    j--;
                }
            }


            return closestpair;
        }
    }



}
