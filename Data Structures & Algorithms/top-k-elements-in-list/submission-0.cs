public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            freqMap.TryGetValue(nums[i], out int val);
            if (val == 0) {
                freqMap.Add(nums[i], 1);
            } else {
                freqMap[nums[i]] = ++val;
            }
        }
        PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
        foreach (var e in freqMap) {
            pq.Enqueue(e.Key,e.Value);
            if(pq.Count>k){
                pq.Dequeue();
            }
            // Console.WriteLine(e);
        }
        int[] res = new int[k];
        for (int i = 0; i < k; i++) {
            res[i] = pq.Dequeue();
        }
        return res;
    }
}
