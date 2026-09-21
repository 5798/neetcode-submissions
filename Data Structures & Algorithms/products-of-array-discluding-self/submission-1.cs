public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int l=1;
        var n = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
            n[i]=l;
            l=l*nums[i];
        }

        l=1;
        
        for(int i=nums.Length-1; i>=0; i--)
        {
            n[i]=n[i]*l;
            l=l*nums[i];
        }

        return n;

    }
}
