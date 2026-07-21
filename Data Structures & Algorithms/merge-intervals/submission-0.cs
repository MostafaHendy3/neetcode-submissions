public class Solution {
    public int[][] Merge(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> output = new List<int[]>();
        output.Add(intervals[0]);
        foreach(int[] e in intervals){
            int start = e[0];
            int end = e[1];
            int lastEnd = output[output.Count-1][1];

            if(start <= lastEnd ){
                output[output.Count-1][1] = Math.Max(end,lastEnd);
            }else{
                output.Add(e);
            }
        }
        return output.ToArray();
    }
}
