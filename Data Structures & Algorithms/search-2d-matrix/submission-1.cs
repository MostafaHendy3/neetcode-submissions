public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix[0].Length;
        int n = matrix.Length ;
        int r = m*n -1 ;
        int l = 0 ;
        int mid = l + (r-l)/2;
        while(l<= r){
            mid = l + (r-l)/2;
            if(matrix[mid/m][mid%m] > target){
                r = mid -1;
            }
            else if(matrix[mid/m][mid%m] < target){
                l = mid + 1;
            }else{
                return true;
            }
        }
        return false;
    }
}
