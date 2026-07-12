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
    public ListNode ReverseList(ListNode head) {
        if (head == null) {
            return null;
        }
        ListNode first = head;
        ListNode prev = null;
        ListNode temp = first.next;
        while (first != null) {
            temp = first.next;
            first.next = prev;
            prev = first;
            first = temp;
        }
        return prev;
    }
}
