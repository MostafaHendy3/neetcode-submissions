public class Solution {
    public int[] SortArray(int[] nums) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var e in nums){
            pq.Enqueue(e,e);
        }
        return pq.UnorderedItems.OrderBy(item => item.Priority).Select(item => item.Element).ToArray();
    }
}