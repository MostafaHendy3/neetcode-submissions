public class Solution {
    public bool IsAnagram(string s, string t) {
        s =s.ToLower();
        t= t.ToLower();
        char[] freq_arr = new char[26];
        for (int i =0; i< s.Length ;i++){
            freq_arr[s[i]-97]++;
        }
        for (int i =0; i< t.Length ;i++){
            freq_arr[t[i]-97]--;
        }
        for(int i = 0 ; i <26 ;i++){
            if(freq_arr[i]!=0){
                return false;
            }
        }
        return true;
    }
}
