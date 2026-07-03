public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string ,List<string>> hashMap = new Dictionary<string ,List<string>>();
        foreach(var s in strs){
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sSorted = new string(charArray);
            if(!hashMap.ContainsKey(sSorted)){
                hashMap.TryAdd(sSorted , new List<string>(){s});
            }else{
                hashMap.TryGetValue(sSorted,out List<string> val);
                val.Add(s);
                hashMap.TryAdd(sSorted,val);
            }
        }
        return hashMap.Values.ToList<List<string>>();

    }
}
