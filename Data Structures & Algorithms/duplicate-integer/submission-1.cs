public class Solution {
    public bool hasDuplicate(int[] nums) {
        var set = new HashSet<int>(nums);
        if(set.Count!=nums.Length)
            return true;
        return false;
    }
}