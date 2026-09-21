/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        ListNode slow=head;
        ListNode fast=head;

        // find mid element
        while(fast != null && fast.next!=null)
        {
            slow=slow.next;
            fast=fast.next.next;
        }

        // reverse 2nd half
        ListNode second = reverse(slow.next);
        // cut the list
        slow.next= null;

        ListNode first = head;
        while (second != null)
        {
            ListNode next1 = first.next;
            ListNode next2 = second.next;

            first.next = second;
            second.next = next1;

            first = next1;
            second = next2;
        }
        
    }

    public ListNode reverse(ListNode head)
    {
        ListNode prev=null;
        ListNode temp=null;
        while(head!=null)
        {   
            temp=head.next;
            head.next=prev;
            prev=head;
            head=temp;
        }
        return prev;
    }
}
