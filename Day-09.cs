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

         ListNode prevPointer = null; //before
         ListNode currPointer = head; // thispointer
         ListNode nextPointer = null; // after

        while(currPointer != null)
        {
           nextPointer= currPointer.next; // Save the next pointer
           currPointer.next = prevPointer; //and then we reverse, point the current node to its previous node, previous node becomes the node we're sitting on
           prevPointer = currPointer; //the previous node becomes the new current node
           currPointer = nextPointer;   //  the current node becomes the node that we saved... which was next
        }

        return prevPointer; //at the end our previous node will be pointing at the head on the new list
        
    }
}
