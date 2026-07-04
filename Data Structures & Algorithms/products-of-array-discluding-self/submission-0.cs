public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int M = 1;
        int NumberOfZeros=0;
        foreach(var e in nums ){
            if(e!=0){
                M = e * M;
            }else{
                NumberOfZeros++;
            }
        }
        int[] res = new int[nums.Length];
        for(int i = 0 ; i< nums.Length;i++){
            if(NumberOfZeros == 0){
                res[i] = M/nums[i];
            }else if (NumberOfZeros ==1 ){
                if(nums[i]==0){
                    res[i] = M ;
                }else{
                    res[i] = 0;
                }
            }else{
                 res[i]=0;
            }
        }
        return res;
    }
}
