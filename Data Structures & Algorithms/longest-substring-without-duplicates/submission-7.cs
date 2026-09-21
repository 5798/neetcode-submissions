public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==0)
            return 0;
        var h = new HashSet<char>();
        int l =0;
        int r =0;
        int max=int.MinValue;

        while(r<s.Length)
        {
            while(h.Contains(s[r]))
            {
                h.Remove(s[l]);
                l++;
            }

            h.Add(s[r]);
            r++;
            max = int.Max(max, h.Count);
        }
        return max;
    }
}
