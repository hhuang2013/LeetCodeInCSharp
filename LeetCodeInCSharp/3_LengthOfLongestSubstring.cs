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

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
                return s.Length;

            int maxlen = 0;
            for (int i = 0, j = 1, len = 0; j < s.Length; j++)
            {
                string sub = s.Substring(i,j-i);
                len = sub.Length;
                int f = sub.IndexOf(s[j]);
                if (f>=0)
                    i += f + 1;
                else
                    len += 1;
                maxlen = len > maxlen ? len : maxlen;
            }
            return maxlen;
        }

        //public static int LengthOfLongestSubstring(string s)
        //{
        //    if (s.Length <= 1)
        //        return s.Length;

        //    int maxlen = 1;
        //    StringBuilder subbd = new StringBuilder(s.Length);
        //    for (int i = 0; i < s.Length - 1; i++)
        //    {
        //        int len = 1;
        //        subbd.Clear();
        //        for (int j = i + 1; j < s.Length; j++)
        //        {
        //            subbd.Append(s[j - 1]);
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


        //public static int LengthOfLongestSubstring(string s)
        //{
        //    if (s.Length <= 1)
        //        return s.Length;

        //    Dictionary<char, int> map = new Dictionary<char, int>();
        //    int maxlen = 0;

        //    for (int i = 0, j = 0, new_j = 0,len = 0; i < s.Length; i++)
        //    {
        //        if(map.ContainsKey(s[i]))
        //        {
        //            new_j = map[s[i]] + 1;
        //            j = new_j > j ? new_j : j;
        //            map[s[i]] = i;
        //        }
        //        else
        //        {
        //            map.Add(s[i], i);
        //        }

        //        len=i - j + 1;
        //        maxlen = len > maxlen ? len : maxlen;
        //    }
        //    return maxlen;
        //}
    }
}
