using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class LongestPalindromicSubstringSolution
    {
        //public static string LongestPalindrome(string s)
        //{
        //    if (s.Length <= 1)
        //        return s;

        //    string ans="";
        //    int maxlen = 0;
        //    for (int i = 0; i < s.Length;i++)
        //    {
        //        for (int j = i,len=0; j < s.Length; j++)
        //        {
        //            len = j - i + 1;
        //            if (len <= maxlen)
        //                continue;
        //            string sub = s.Substring(i, len);

        //            if (isPalindromic(sub))
        //            {
        //                ans = sub;
        //                maxlen = sub.Length;
        //            }
        //        }
        //    }
        //    return ans;
        //}
        //public static bool isPalindromic(string s)
        //{
        //    for(int i=0;i<s.Length/2;i++)
        //    {
        //        if (s[i] != s[s.Length-1-i])
        //            return false;
        //    }
        //    return true;
        //}

        //public static string LongestPalindrome(string s)
        //{
        //    int maxlen = 0;
        //    string res = "";
        //    for(int i=0;i<s.Length;i++)
        //    {
        //        int len = expandAroundCenter(s,i, i);
        //        if ( i<s.Length-1 && s[i]==s[i+1])
        //        {
        //            int len2 = expandAroundCenter(s, i-1, i + 2);
        //            len = len2 > len ? len2 : len;
        //        }
        //        if(len>maxlen)
        //        {
        //            maxlen = len;
        //            res = s.Substring(i - (len - 1) / 2, len);
        //        }
                
        //    }
        //    return res;
        //}

        //public static int expandAroundCenter(String s, int L, int R)
        //{
        //    while (L >= 0 && R < s.Length && s[L] == s[R])
        //    {
        //        L--;
        //        R++;
        //    }
        //    return R-L-1;
        //}


        public static string LongestPalindrome(string s)
        {
            int N = s.Length;
            if (N == 0)
                return "";
            N = 2 * N + 1; //Position count
            int[] L = new int[N]; //LPS Length Array
            L[0] = 0;
            L[1] = 1;
            int C = 1; //centerPosition 
            int R = 2; //centerRightPosition
            int i = 0; //currentRightPosition
            int iMirror; //currentLeftPosition
            int maxLPSLength = 0;
            int maxLPSCenterPosition = 0;
            int start = -1;
            int end = -1;
            int diff = -1;
            int expand = -1;

            //Uncomment it to print LPS Length array
            //printf("%d %d ", L[0], L[1]);
            for (i = 2; i < N; i++)
            {
                //get currentLeftPosition iMirror for currentRightPosition i
                iMirror = 2 * C - i;
                //Reset expand - means no expansion required
                expand = 0;
                diff = R - i;
                //If currentRightPosition i is within centerRightPosition R
                if (diff > 0)
                {
                    if (L[iMirror] < diff) // Case 1
                        L[i] = L[iMirror];
                    else if (L[iMirror] == diff && i == N - 1) // Case 2
                        L[i] = L[iMirror];
                    else if (L[iMirror] == diff && i < N - 1)  // Case 3
                    {
                        L[i] = L[iMirror];
                        expand = 1;  // expansion required
                    }
                    else if (L[iMirror] > diff)  // Case 4
                    {
                        L[i] = diff;
                        expand = 1;  // expansion required
                    }
                }
                else
                {
                    L[i] = 0;
                    expand = 1;  // expansion required
                }

                if (expand == 1)
                {
                    //Attempt to expand palindrome centered at currentRightPosition i
                    //Here for odd positions, we compare characters and 
                    //if match then increment LPS Length by ONE
                    //If even position, we just increment LPS by ONE without 
                    //any character comparison
                    while (((i + L[i]) < N && (i - L[i]) > 0) &&
                        (((i + L[i] + 1) % 2 == 0) ||
                        (s[(i + L[i] + 1) / 2] == s[(i - L[i] - 1) / 2])))
                    {
                        L[i]++;
                    }
                }

                if (L[i] > maxLPSLength)  // Track maxLPSLength
                {
                    maxLPSLength = L[i];
                    maxLPSCenterPosition = i;
                }

                // If palindrome centered at currentRightPosition i 
                // expand beyond centerRightPosition R,
                // adjust centerPosition C based on expanded palindrome.
                if (i + L[i] > R)
                {
                    C = i;
                    R = i + L[i];
                }
                //Uncomment it to print LPS Length array
                //printf("%d ", L[i]);
            }
            //printf("\n");
            start = (maxLPSCenterPosition - maxLPSLength) / 2;
            end = start + maxLPSLength - 1;
            return s.Substring(start, maxLPSLength);
            //printf("LPS of string is %s : ", text);
            //for(i=start; i<=end; i++)
            //    printf("%c", text[i]);
            //printf("\n");
        }
    }
}
