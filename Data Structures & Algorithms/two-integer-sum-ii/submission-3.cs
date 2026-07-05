public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        for (int num = 0; num < numbers.Length; num++) {
            int l = num + 1;
            int r = numbers.Length -1;
            int mid = l + (r - l) / 2;
            while (l <= r) {
                mid = l + (r - l) / 2;
                if (numbers[mid] < target - numbers[num]) {
                    l = mid + 1;
                } else if (numbers[mid] > target - numbers[num]) {
                    r = mid - 1;
                } else {
                    if (numbers[mid] + numbers[num] == target)
                        return new int[2] { num + 1, mid + 1 };
                }
            }
        }
        return new int[2];
    }
}
