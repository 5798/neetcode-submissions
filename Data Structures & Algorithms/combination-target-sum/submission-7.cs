public class Solution {
    private List<List<int>> list = new List<List<int>>();
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var l = new List<int>();
        
        Recursion(0, target, l, nums);
        return list;
    }

    public void Recursion(int i, int target, List<int> l, int[] nums)
    {
        if(i>=nums.Length || target<0)
            return;
        if(target == 0)
        {
            list.Add(new List<int>(l));
            return;
        }
        l.Add(nums[i]);
        Recursion(i, target-nums[i], l, nums);
        l.RemoveAt(l.Count-1);

        Recursion(i+1, target, l, nums);
    }
}
