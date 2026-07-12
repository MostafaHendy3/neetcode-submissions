public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cols = matrix[0].Length;
        int rows = matrix.Length;
        int r = rows * cols - 1;
        int l = 0;
        int mid = 0;
        while (l <= r) {
            mid = l + (r - l) / 2;
            if (matrix[mid / cols][mid % cols] > target) {
                r = mid - 1;
            } else if (matrix[mid / cols][mid % cols] < target) {
                l = mid + 1;
            } else {
                return true;
            }
        }
        return false;
    }
}
