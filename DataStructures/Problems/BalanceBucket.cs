using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    internal static class BalanceBucket
    {
        public static string isBalanced(string s)
        {

            return BalacedExp(s.ToArray()) ? "YES" : "NO";

        }


        private static bool BalacedExp(char[] arr)
        {
            Stack<char> stack = new Stack<char>();

            int i, len = arr.Length;
            for (i = 0; i < len; i++)
            {
                if (arr[i] == '(' || arr[i] == '{' || arr[i] == '[')
                    stack.Push(arr[i]);
                else
                {
                    if (stack.Count == 0)
                        return false;

                    if (!HasExpressionMatched(stack.Pop(), arr[i]))
                        return false;
                }

            }

            if (stack.Count == 0)
                return true;

            return false;
        }

        private static bool HasExpressionMatched(char s, char e)
        {
            if (s == '(' && e == ')')
                return true;
            if (s == '{' && e == '}')
                return true;
            if (s == '[' && e == ']')
                return true;
            return false;

        }

    }
}
