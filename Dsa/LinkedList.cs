using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LinkedListS
    {
        public class ListNode
        {
            public int Val { get; set; }    // Value stored in the node
            public ListNode Next { get; set; }   // Reference to the next node

            public ListNode(int val)
            {
                Val = val;
                Next = null;
            }
        }

        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.Next == null)
                return false;   // No cycle can exist if there are 0 or 1 nodes

            ListNode slow = head;   // Slow pointer moves 1 step at a time
            ListNode fast = head.Next;   // Fast pointer moves 2 steps at a time

            while (fast != null && fast.Next != null)
            {
                if (slow == fast)
                    return true;    // If slow and fast pointers meet, a cycle exists

                slow = slow.Next;    // Move slow pointer by 1 step
                fast = fast.Next.Next;   // Move fast pointer by 2 steps
            }

            return false;   // If fast pointer reaches the end, no cycle exists
        }
    }
}
