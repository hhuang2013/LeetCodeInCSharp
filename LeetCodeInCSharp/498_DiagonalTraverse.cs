using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class DiagonalTraverseSolution
    {
        public static int[] FindDiagonalOrder(int[,] matrix)
        {
            int r = matrix.GetLength(0);
            int c = matrix.GetLength(1);
            int[] res = new int[r * c];
            int k=0;
            for (int i = 0; i <= r + c - 2; i++)
            {
                if (i % 2 == 1)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if ((j>r-1) | (i - j > c - 1))
                            continue;
                        res[k] = matrix[j, i - j];
                        k++;
                    }
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        if ((i - j > r - 1) | (j>c-1))
                            continue;
                        res[k] = matrix[i - j, j];
                        k++;
                    }
                 }
            }
            return res;
        }
    }
}
