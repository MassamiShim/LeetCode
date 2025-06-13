using System;

namespace ConsoleApp1;

public class Exercise21
{
    public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
        }
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode result = new ListNode();

        if (list1 == null && list2 == null)
            return null;

        if (list2 == null || list1 != null && list1.val <= list2.val)
            {
                result = list1;
                if (result != null)
                {
                    list1 = list1.next;
                    if (list1 != null || list2 != null)
                        result.next = MergeTwoLists(list1, list2);
                }
            }
            else
            {
                if (list2 != null)
                {
                    result = list2;
                    if (result != null)
                    {
                        list2 = list2.next;
                        result.next = MergeTwoLists(list1, list2);
                    }

                }
            }

        return result;
    }

    public ListNode Run(ListNode list1, ListNode list2)
    {
        // ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        // ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        // ListNode list1 = new ListNode(1);
        // ListNode list2 = null;

        ListNode result = MergeTwoLists(list1, list2);

        return result;
    }

}


