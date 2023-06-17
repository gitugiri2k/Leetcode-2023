using System;
namespace Leetcode_2023
{
    public class LT_206_Reverse_Linked_List
    {
        public LT_206_Reverse_Linked_List()
        {
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            ListNode temp=null;
            if (head != null)
            {
                while (curr.next != null)
                {
                    
                    temp = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = temp;
                }
                curr.next = prev;
            }
            //1 > 2 > 3 > 4
            //1.prev = null
            //1.next = 2
            //2.prev = 1
            //2.next = 3
            //3.prev = 2
            //3.next = 4
            return curr;
        }
    }
}

