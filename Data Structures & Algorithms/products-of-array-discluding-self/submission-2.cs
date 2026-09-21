public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var p = new int[nums.Length];
        p[0]=1;
        int prd=1;
        for(int i=1;i< nums.Length;i++)
        {
            p[i]=nums[i-1]*prd;
            prd=p[i];
        }

        prd=1;
        var p2 = new int[nums.Length];
        p2[nums.Length-1]=1;

        for(int i=nums.Length-2;i>=0;i--)
        {
            p2[i]=nums[i+1]*prd;
            prd=p2[i];
        }

        for(int i=0;i< nums.Length;i++)
        {
            p[i]=p[i]*p2[i];
        }
        return p;
    }
}
