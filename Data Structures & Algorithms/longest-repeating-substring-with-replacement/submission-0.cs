public class Solution {
    public int CharacterReplacement(string s, int k) {
        HashSet<char> set = new HashSet<char>();
        foreach (var e in s) {
            set.Add(e);
        }
        int res = 0;
        foreach (var ele in set) {
            int l = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++) {
                if (ele == s[i]) {
                    count++;
                }
                while (i - l + 1 - count > k) {
                    if (ele == s[l]) {
                        count--;
                    }
                    l++;
                }
                res = Math.Max(res, i - l + 1);
            }
        }
        return res;
    }
}
