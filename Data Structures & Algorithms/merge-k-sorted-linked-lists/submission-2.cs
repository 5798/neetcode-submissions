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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists.Length ==0)
            return null;
        int count = lists.Length;
        
        var newlist = new List<ListNode>();
        while(count>1)
        {
            for(int i=0; i<count; i+=2)
            {   
                ListNode p1 = lists[i];
                if(i+1<count)
                {
                    ListNode p2 = lists[i+1];
                    newlist.Add(merge(p1,p2));
                }
                else
                {
                    newlist.Add(p1);
                }
            }
            count = newlist.Count;
            lists = newlist.ToArray();
            newlist.Clear();
        }
        if(lists.Length==0)
            return null;
        else
            return lists[0];
    }

    public ListNode merge(ListNode p1, ListNode p2)
    {
        ListNode templist = new ListNode(0);
        ListNode head = templist;
        while(p1!=null && p2!=null)
        {
            if(p1.val<=p2.val)
            {
                templist.next=p1;
                p1=p1.next;
            }
            else
            {
                templist.next=p2;
                p2=p2.next;
            }
            templist=templist.next;
        }

        while(p1!=null)
        {
            templist.next=p1;
            p1=p1.next;
            templist=templist.next;
        }

        while(p2!=null)
        {
            templist.next=p2;
            p2=p2.next;
            templist=templist.next;
        }
        return head.next;
    }
}
