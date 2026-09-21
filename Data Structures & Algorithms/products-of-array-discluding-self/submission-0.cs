public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int l=1;
        var n = new int[nums.Length];
        for(int i=0; i<nums.Length; i++)
        {
            n[i]=l;
            l=l*nums[i];
        }

        var m = new int[nums.Length];
        l=1;
        
        for(int i=nums.Length-1; i>=0; i--)
        {
            m[i]=l;
            l=l*nums[i];
        }

        for(int i=0; i<nums.Length; i++)
        {
            n[i]=n[i]*m[i];
        }

        return n;

    }
}
