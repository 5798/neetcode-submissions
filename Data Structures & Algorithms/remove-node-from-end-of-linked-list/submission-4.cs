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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode fast = head;
        ListNode slow = head;
        while(n>0&&fast!=null)
        {
            fast=fast.next;
            n--;
        }

        while(fast!=null&&fast.next!=null)
        {
            slow=slow.next;
            fast=fast.next;
        }
        if(fast==null)
            slow=slow.next;
        else
            slow.next=slow.next.next;

        if(slow==null || fast==null)
            return slow;
        else
            return head;
    }
}
