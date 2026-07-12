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
        // find mid
        
        ListNode mid = FindMid(head);

        ListNode rev = Reverse(mid);
 
        Merge(head , rev);

    }

    public ListNode FindMid(ListNode head){ 
        ListNode fast = head.next;
        ListNode slow = head;

        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode second = slow.next;
        slow.next = null;
        return second;
    }


    public ListNode Reverse(ListNode head){
        ListNode first = head;
        ListNode prev = null;

        while (first != null) {
            ListNode temp = first.next;
            first.next = prev;
            prev = first;
            first = temp;
        }
        return prev;
    }

    public void Merge (ListNode first , ListNode second){
        while ( second != null ){
            ListNode t1 = first.next, t2 = second.next;
            first.next = second;
            second.next = t1;
            first = t1;
            second = t2;
        }

    }


}
