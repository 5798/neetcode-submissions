public class Solution {
    Dictionary<int, int> dir = new Dictionary<int, int>();
    public int Rob(int[] nums) {
    
    if(nums.Length==0)
        return 0;
    return sum(0, nums);

    }

    public int sum(int i,int[] nums)
    {
        if(i>=nums.Length)
            return 0;
        
        if(dir.TryGetValue(i, out int val))
        {
            return val;
        }
        var n = Math.Max( (nums[i]+ sum(i+2, nums)), (sum(i+1, nums)));
        dir[i]= n;
        return n;
    }
}
