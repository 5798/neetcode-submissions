public class Solution {
    public int CharacterReplacement(string s, int k) {
        var n = new int[26];
        int l=0;
        int max=0;
        for(int r=0; r<s.Length ; r++)
        {
            n[s[r]-'A']++;
            while(((r-l+1) - n.Max())>k)
            {
                n[s[l]-'A']--;
                l++;
            }
            max = Math.Max(max, r-l+1);

        }
        return max;
    }
}
