using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] res = { -1, -1 };
            int i, j;
            for (i = 0; i <= nums.Length - 2; i++)
            {
                for (j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                        return res;
                    }
                }
            }
            return res;    
        }
    }
}
