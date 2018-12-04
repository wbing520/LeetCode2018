//160. Intersection of Two Linked Lists

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        if(headA == null || headB == null) return null;
        
        int al = GetListNodeLength(headA);
        int bl = GetListNodeLength(headB);
        
        ListNode cur = al >= bl? headA: headB;        
        int step = al >= bl? (al - bl) : (bl - al);
        while(step != 0)
        {
            step--;
            cur = cur.next;
        }        
        
        ListNode cur2 = al >= bl? headB: headA;
        
        while(cur != cur2 && cur != null && cur2 != null)
        {
            cur = cur.next;
            cur2 = cur2.next;
        }
        
        if(cur == cur2 && cur != null) return cur;
        
        else return null;
        
    }
    
    private int GetListNodeLength(ListNode head)
    {
        if(head == null) return 0;
        
        int len = 0;
        ListNode cur = head;
        while(cur != null)
        {            
            cur = cur.next;
            len++;
        }
        
        return len;        
    }
}