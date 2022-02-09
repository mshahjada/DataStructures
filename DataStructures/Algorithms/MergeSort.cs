using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    public class MergeSort
    {
        private void Apply(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                Apply(arr, l, m);
                Apply(arr, m + 1, r);
                Merge(arr, l, m, r);
            }
        }


        private void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] la = new int[n1];
            int[] ra = new int[n2];

            int i, j;
            for (i = 0; i < n1; i++)
                la[i] = arr[l+i];

            for (j = 0; j < n2; j++)
                ra[j] = arr[m+1+j];


            i = 0; j = 0;

            int k = l;
            while(i<n1 && j < n2)
            {
                if(la[i] < ra[j]) { 
                    arr[k] = la[i];
                    i++;
                }
                else
                {
                    arr[k] = ra[j];
                    j++;
                }
                k++;
            }

            while (j < n2)
            {
                arr[k] = ra[j];
                j++;
                k++;
            }

            while (i < n1)
            {
                arr[k] = la[i];
                i++;
                k++;
            }
        }

        public void Initialize()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Apply(arr, 0, arr.Length-1);
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
