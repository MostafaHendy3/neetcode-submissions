public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length-1;
        int maxWater= 0;

        while (l<r){
            int area = (Math.Min(heights[l], heights[r])) * (r - l);
            maxWater = Math.Max(area, maxWater);
            if (heights[l] <= heights[r]){
                l++;
            } else{
                r--;
            }
        }

        return maxWater;

    }
}
