using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    internal class Permutation
    {
        public int Apply(string str, int l, int r)
        {
            if (l == r)
                return 1;
                //Console.WriteLine(str);

            int total = 0;
            for(int i=l; i<=r; i++)
            {
                str  = Swap(str, l, i);
                total += Apply(str, l+1, r);
                //str = Swap(str, l, i);
            }
            return total;
        }

        string Swap(string str, int l, int r)
        {
            char temp;

            char[] arr = str.ToCharArray();

            temp = arr[l];

            arr[l] = str[r];
            arr[r] = temp;

            return new string(arr);
        }


        public void Initialize()
        {
            string str = "ABC";
            Console.WriteLine($"{Apply(str, 0, str.Length - 1)}");
        }
    }
}
