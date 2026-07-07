public class Solution {
    public int Search(int[] nums, int target) {
        int r = nums.Length -1 ;
        int l = 0;
        int mid = l+ (r-l)/2;
        while(l<=r){
            mid = l+ (r-l)/2;
            if(nums[mid] < target){
                l = mid+1;
            }else if (nums[mid] > target){
                r= mid-1;
            }else{
                return mid;
            }
        }
        return -1;
    }
}
