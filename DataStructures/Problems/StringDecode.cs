using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    public class StringDecode
    {
        private char[] DATASET = new char[]
        {
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z'
        };
        public string Encode(string key)
        {
            return Helper(key, key.Length).ToString();
        }

        public StringBuilder result = new StringBuilder("");
        private string Helper(string key, int len)
        {
            if (len == 0)
                return "";
            
            int  i= key.Length - len;

            if (key.Substring(i,1) == "0")
                return "";

            result.Append(DATASET[Convert.ToInt32(key.Substring(i, 1)) - 1]);
            Helper(key, len - 1);
            var index = (len>=2)?Convert.ToInt32(key.Substring(i, 2)) : -1;
            if (index>-1 && index <= 26)
            {
                result.Append(DATASET[index - 1]);
            }
           
            return result.ToString();
        }
    }
}
