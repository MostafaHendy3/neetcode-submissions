public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
        foreach (int e in nums) {
            result ^= e;
        }
        return result;
    }
}
