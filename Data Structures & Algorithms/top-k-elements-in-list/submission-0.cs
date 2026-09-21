public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dir = new Dictionary<int, int>();
        var n = new int[k];
        foreach(var x in nums)
        {
            if(dir.ContainsKey(x))
            {
                dir[x]++;
            }
            else
                dir[x]=1;
        }

        var sorted = dir.OrderByDescending(x=>x.Value).Take(k);
        int i=0;
        foreach(var x in sorted)
        {
            n[i]=x.Key;
            i++;
        }
        return n;
    }
}
