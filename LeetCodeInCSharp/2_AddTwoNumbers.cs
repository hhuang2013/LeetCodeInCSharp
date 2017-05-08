using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeInCSharp
{
    public class AddTwoNumbersSolution
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode p1 = l1;
            ListNode p2 = l2;
            ListNode pre = null;
            ListNode res = null;
            int c = 0;
            int sum;
            while (p1 != null || p2 != null || c > 0)
            {
                sum = 0;
                if (p1 != null)
                {
                    sum += p1.val;
                    p1 = p1.next;
                }
                if (p2 != null)
                {
                    sum += p2.val;
                    p2 = p2.next;
                }
                sum += c;

                c = sum / 10;
                sum = sum % 10;

                ListNode cur = new ListNode(sum);
                if (pre == null)
                {
                    res = cur;
                }
                else
                {
                    pre.next = cur;
                }
                pre = cur;
            }
            return res; 
        }
    }
}
