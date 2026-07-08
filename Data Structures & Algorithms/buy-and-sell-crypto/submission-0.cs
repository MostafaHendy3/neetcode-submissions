public class Solution {
    public int MaxProfit(int[] prices) {
        int R = 0;
        int L = 0;
        int maxProfit = 0;
        for(int i = 0 ; i < prices.Length ; i++){
            R = i;
            while(prices[R] < prices[L]){
                L++;
            }
            maxProfit = Math.Max(maxProfit,prices[R] -prices[L]);
        }
        return maxProfit;
    }
}
