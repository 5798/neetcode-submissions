public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dir = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++)
        {
            if(dir.TryGetValue(target-nums[i], out int c))
                return new int[] {c,i};
            else
                dir.Add(nums[i], i);
        }
        return Array.Empty<int>();
    }
}
