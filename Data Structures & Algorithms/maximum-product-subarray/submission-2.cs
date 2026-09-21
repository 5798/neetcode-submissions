public class Solution {
    public int MaxProduct(int[] nums) {
        int max =1;
        int min =1;
        int result = int.MinValue;

        for(int i=0;i<nums.Length;i++)
        {
            int oldMax = max;
            int oldMin = min;
            max = Math.Max(nums[i], Math.Max(nums[i]*oldMax, nums[i]*oldMin));
            min = Math.Min(nums[i], Math.Min(nums[i]*oldMax, nums[i]*oldMin));
            
            result = Math.Max(result, max);
        }
        return result;
    }
}
