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
        ListNode mid = FindMid(head);
        // Console.WriteLine(mid.val);
        ListNode rev = Reverse(mid); 
        // Console.WriteLine(rev.val);
        Merge(head,rev);
    }

    private ListNode FindMid(ListNode head){
        ListNode slow = head;
        ListNode fast = head.next;
        while(fast != null && fast.next != null ){
            fast = fast.next.next;
         
            slow = slow.next;
        }
        ListNode second = slow.next;
        slow.next = null;
        return second;
    }
    private ListNode Reverse(ListNode head){
        ListNode first = head;
        ListNode prev = null;
        while(first !=null ){
            ListNode temp = first.next;
            first.next = prev;
            prev=first;
            first =temp;
        }
        return prev;
    }
    private void Merge (ListNode first , ListNode second){
        while(second !=null){
            ListNode t1 =first.next; 
            ListNode t2 = second.next;
            first.next =second;
            second.next = t1;
            first=t1;
            second =t2;
        }
    }
}
