public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach (var e in nums) {
            pq.Enqueue(e, e);
            if (pq.Count > k)
                pq.Dequeue();
        }

        return pq.Peek();
    }
}
