using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class LongestPalindromicSubstringSolution
    {
        public static string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
                return s;

            string ans="";
            int maxlen = 0;
            for (int i = 0; i < s.Length;i++)
            {
                for (int j = i,len=0; j < s.Length; j++)
                {
                    len = j - i + 1;
                    if (len <= maxlen)
                        continue;
                    string sub = s.Substring(i, len);

                    if (isPalindromic(sub))
                    {
                        ans = sub;
                        maxlen = sub.Length;
                    }
                }
            }
            return ans;
        }
        public static bool isPalindromic(string s)
        {
            for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] != s[s.Length-1-i])
                    return false;
            }
            return true;
        }
    }
}
