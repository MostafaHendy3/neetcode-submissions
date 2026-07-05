public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        foreach (var e in stones ){
            minHeap.Enqueue(-e,-e);
        }
        while(minHeap.Count > 1){
            var e1 = minHeap.Dequeue();
            var e2 = minHeap.Dequeue();
            if(e1 < e2){
                minHeap.Enqueue(e1-e2,e1-e2);
            }
        }
        minHeap.Enqueue(0,0);
        return Math.Abs(minHeap.Peek());
    }
}
