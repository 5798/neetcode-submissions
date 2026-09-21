public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length == 0)
            return false;
        var h = new HashSet<int>();
        foreach(var x in nums)
        {
            if(h.Contains(x))
                return true;
            else
                h.Add(x);
        }
        return false;
    }
}