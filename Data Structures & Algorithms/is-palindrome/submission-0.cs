public class Solution {
    public bool IsPalindrome(string s) {
        string filtered = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();
        string revFiltered = new string(filtered.Reverse().ToArray()).ToLower();
        return filtered == revFiltered;
    }
}
