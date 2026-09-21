public class Solution {
    public int MaxProfit(int[] prices) {
        int min=prices[0];
        int max=0;
        for(int i=0; i<prices.Length;i++)
        {
            max=Math.Max(max, prices[i]-min);
            min=Math.Min(min, prices[i]);
        }
        return max;
    }
}
