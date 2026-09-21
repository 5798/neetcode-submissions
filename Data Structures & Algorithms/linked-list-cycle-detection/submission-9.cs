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
    public bool HasCycle(ListNode head) {
        if(head==null || head.next ==null)
            return false;
        ListNode fast=head.next;
        ListNode slow=head;
        while(fast.next!=null  && fast.next.next!=null)
        {
            if(fast==slow)
                return true;
            fast=fast.next.next;
            slow=slow.next;
        }
        return false;
    }
}
