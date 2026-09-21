public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dir = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(dir.ContainsKey(target-nums[i]))
                return new int[] {dir[target-nums[i]],i};
            else
                dir.Add(nums[i], i);
        }
        return Array.Empty<int>();
    }
}
