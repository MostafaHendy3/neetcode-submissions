public class KthLargest {
    private PriorityQueue<int, int> minHeap;
    private int kth;
    public KthLargest(int k, int[] nums) {
        kth = k;
        minHeap = new PriorityQueue<int, int>();
        foreach (var e in nums){
            minHeap.Enqueue(e,e);
        }
    }
    
    public int Add(int val) {
        minHeap.Enqueue(val,val);
        while(minHeap.Count > kth){
            minHeap.Dequeue();
        }
        return minHeap.Peek();
    }

}
