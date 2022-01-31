using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Problems
{
    internal static class ContactsProblem
    {
        public static List<int> Contacts(List<List<string>> queries)
        {
            List<int> arr = new List<int>();
            Dictionary<string, int> keys = new Dictionary<string, int>();

            int i, l = queries.Count();
            string key = string.Empty;

            for (i = 0; i < l; i++)
            {
                if (queries[i][0] == "add")
                {
                    key = string.Empty;
                    var letters = queries[i][1].ToCharArray();
                    for (int j = 0; j < letters.Length; j++)
                    {
                        key += letters[j];
                        if (keys.ContainsKey(key))
                            keys[key]++;
                        else
                            keys.Add(key, 1);
                    };
                }
                else if (queries[i][0] == "find")
                {
                    if (keys.ContainsKey(queries[i][1]))
                        arr.Add(keys[queries[i][1]]);
                    else
                        arr.Add(0);
                }

            }

            return arr;

        }
    }
}
