public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dir = new Dictionary<int,int>();
        foreach(var i in nums)
        {
            if(!dir.ContainsKey(i))
            {
                dir[i]=0;
            }
            dir[i]++;
        }
        
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var pair in dir)
        {
            if (buckets[pair.Value] == null)
                buckets[pair.Value] = new List<int>();

            buckets[pair.Value].Add(pair.Key);
        }
        List<int> result = new();
            
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
            {
                foreach (int num in buckets[i])
                {
                    result.Add(num);

                    if (result.Count == k)
                        break;
                }
            }
        }

        return result.ToArray();

    }
}
