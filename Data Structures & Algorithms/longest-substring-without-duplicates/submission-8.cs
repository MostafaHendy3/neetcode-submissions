public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0)
            return 0;
        if (s.Length == 1)
            return 1;
        HashSet<char> set = new HashSet<char>();
        int maxLen = int.MinValue;
        int left = 0;
        for (int i =0; i< s.Length;i++){
            while(set.Contains(s[i])){
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[i]);
            maxLen = Math.Max(maxLen , i - left +1);
        }
        return maxLen;

    }
}
