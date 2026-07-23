public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> pq = new();
        foreach(int[] e in points){
            int squared_dis = e[1]*e[1] + e[0] *e[0];
            pq.Enqueue(e,-squared_dis);
            while(pq.Count>k){
                pq.Dequeue();
            }
        }
        List<int[]> res = new();
        for (int i = 0; i < k; i++){
            res.Add(pq.Dequeue());
        }
        return res.ToArray();
    }
}
