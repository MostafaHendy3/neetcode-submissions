public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var e  in strs){
            var arr = e.ToCharArray();
            for(int i =0;i<arr.Length;i++){
                arr[i] = (char)(arr[i] + 1);
            }
            string encoded = new String(arr);
            sb.Append(encoded);
            sb.Append(' ');
            // Console.WriteLine(encoded.ToString());
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var lst  = s.Split(' ').ToList();
        var res = new List<string>();
        foreach(var e  in lst){
            var arr = e.ToCharArray();
            for(int i =0;i<arr.Length;i++){
                arr[i] = (char)(arr[i] - 1);
            }
            res.Add(new String(arr));
        }
        res.RemoveAt(res.Count - 1);
        return res;
   }
}
