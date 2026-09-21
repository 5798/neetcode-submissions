public class Solution {
    public int MissingNumber(int[] nums) {
        if(nums.Length ==0)
            return 0;
        int n=0;
        foreach(int i in nums)
        {
            n=n^i;
        }
        for(int i=0 ; i<= nums.Length;i++)
        {
            n=n^i;
        }
        return n;
    }
}
