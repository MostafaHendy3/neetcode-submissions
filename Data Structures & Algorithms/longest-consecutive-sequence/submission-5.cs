public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        if (nums.Length == 0)
            return 0;
        foreach (var e in nums) set.Add(e);

        int len = 0;
        int maxLen = 0;

        foreach (var e in nums) {
            if (!set.Contains(e - 1)) {
                len = 1;
                while (set.Contains(e + len)) {
                    len++;
                }
                maxLen = Math.Max(maxLen, len);
            }
        }
        return maxLen;
    }
}
