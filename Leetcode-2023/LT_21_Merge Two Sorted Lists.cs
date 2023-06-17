using System;
namespace Leetcode_2023
{
    public class LT_21_Merge_Two_Sorted_Lists
    {
        public LT_21_Merge_Two_Sorted_Lists()
        {
        }
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode prev = new ListNode();
            ListNode head = prev;
            if (list1 == null && list2 == null)
                return list1;
            else if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }
            if (list1 != null)
            {
                prev.next = list1;
            }
            else if (list2 != null)
            {
                prev.next = list2;
            }
            return head.next;
        }
    }
}

