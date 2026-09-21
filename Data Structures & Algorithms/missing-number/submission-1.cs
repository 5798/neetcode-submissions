public class Solution {
    public int MissingNumber(int[] nums) {
        int x=0;
        for(int i=0; i<=nums.Length;i++)
        {
            x=x^i;
        }

        for(int i=0; i<nums.Length;i++)
        {
            x=x^nums[i];
        }
        return x;
        
    }
}
