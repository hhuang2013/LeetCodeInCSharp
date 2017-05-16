using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class LengthOfLongestSubstringSolution
    {
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    if (s.Length <= 1)
        //        return s.Length;

        //    int maxlen = 1;
        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        int len = 1;
        //        for (int j = i + 1; j < s.Length; j++)
        //        {
        //            string sub = s.Substring(i, j - i);
        //            if (sub.Contains(s[j]))
        //                break;
        //            len++;
        //        }
        //        if (len > maxlen)
        //            maxlen = len;
        //    }
        //    return maxlen;
        //}

        //public static int LengthOfLongestSubstring(string s)
        //{
        //    if (s.Length <= 1)
        //        return s.Length;

        //    int maxlen = 1;
        //    StringBuilder subbd =new StringBuilder();
        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        int len = 1;
        //        subbd.Clear(); 
        //        for (int j = i + 1; j < s.Length; j++)
        //        {
        //            subbd.Append(s[j-1]);
        //            string sub = subbd.ToString();
        //            if (sub.Contains(s[j]))
        //                break;
        //            len++;
        //        }
        //        if (len > maxlen)
        //            maxlen = len;
        //    }
        //    return maxlen;
        //}


        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
                return s.Length;

            Dictionary<char, int> map = new Dictionary<char, int>();
            int maxlen = 0;

            for (int i = 0, j = 0; i < s.Length; i++)
            {
                if(map.ContainsKey(s[i]))
                {
                    j = Math.Max(j,map[s[i]])+1;
                    map[s[i]] = i;
                }
                else
                {
                    map.Add(s[i], i);
                }
                maxlen = Math.Max(maxlen, i - j + 1);   
            }
            return maxlen;
        }
    }
}
