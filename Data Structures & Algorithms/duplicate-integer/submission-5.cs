public class Solution {
    public bool hasDuplicate(int[] nums) {
        var h = new HashSet<int>();

        foreach (int i in nums)
        {
            if(h.Contains(i))
                return true;
            else
                h.Add(i);
        }
        return false;
    }
}