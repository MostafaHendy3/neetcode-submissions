public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>();
        if(nums.Length==0){
            return 0;
        }
        foreach (var i in nums) {
            set.Add(i);
        }
        int len = 0;
        int maxLen= 0;
        foreach (var i in nums) {
            if (!set.Contains(i - 1)) {
                len = 1;
                while (set.Contains(i + len)) {
                    len++;
                }
                maxLen = Math.Max(maxLen , len);
            }
        }
        return maxLen;
    }
}
