public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> hashmap = new Dictionary<int, int>();
        int diff = 0;
        for (int i = 0; i < nums.Length; i++) {
            diff = target - nums[i];
            if (hashmap.ContainsKey(diff)) {
                hashmap.TryGetValue(diff, out int pos);
                if (pos != i) {
                    return new int[2] { pos, i };
                }
            }
            hashmap.TryAdd(nums[i], i);
        }
        return new int[2];
    }
}
