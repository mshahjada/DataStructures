using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public static class InsertionSort
    {
        public static int[] Apply(int[] arr)
        {
            int n = arr.Length, temp, i, j;

            for (i = 1; i < n; i++)
            {
                temp = arr[i];

                j = i - 1;
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
