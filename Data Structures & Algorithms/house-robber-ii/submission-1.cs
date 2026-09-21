public class Solution {
    Dictionary<(int, int), int> dir = new Dictionary<(int, int), int>();
    public int Rob(int[] nums) {
        if(nums.Length == 0)
            return 0;
        if(nums.Length == 1)
            return nums[0];
        return Math.Max(SumRob(0, nums.Length-1, nums), SumRob(1, nums.Length, nums));
    }

    public int SumRob(int l, int r, int[] nums)
    {
        if(l>=r)
            return 0;
        if(dir.TryGetValue((l, r), out int val))
        {
            return val;
        }
        
        val = Math.Max(nums[l] + SumRob(l+2, r, nums), SumRob(l+1, r, nums));
        dir[(l, r)] =val;

        return val;
    }
}
