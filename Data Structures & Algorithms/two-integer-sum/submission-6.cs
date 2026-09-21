public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var d = new Dictionary<int, int>();

        for(int i=0; i< nums.Length; i++)
        {
            int diff = target-nums[i];
            if(d.ContainsKey(diff))
            {
                return new[] {d[diff], i};
            }
            d[nums[i]]=i;
        }
        return null;
    }
}
