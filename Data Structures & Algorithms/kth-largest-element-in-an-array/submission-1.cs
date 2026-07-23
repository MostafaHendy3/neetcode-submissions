public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> pq =new();
        foreach(var e in nums){
            pq.Enqueue(e,e);
            while(pq.Count>k){
                pq.Dequeue();
            }
        }
        return pq.Peek();
    }
}
