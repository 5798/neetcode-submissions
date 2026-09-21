public class Solution {

    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
            dp[i]=1;
            for(int j=i-1;j>=0; j--)
            {
                if(nums[j]<nums[i])
                {
                    dp[i]= Math.Max(dp[i], dp[j]+1);
                }
            }
        }
        
    return dp.Max();
    }

    public void Lis(int[] nums, int i)
    {
        
    }
}
