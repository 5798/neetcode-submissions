public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var d = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++)
        {
            if(d.ContainsKey(target-nums[i]))
                return(new int[]{d[target-nums[i]], i});
            else
                d[nums[i]]=i;
        }
        return Array.Empty<int>();
    }
}
