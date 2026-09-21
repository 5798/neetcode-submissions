public class Solution {
    
    int count=0;
    public int CountSubstrings(string s) {
        if(string.IsNullOrEmpty(s))
            return 0;
        
        for(int i=0; i<s.Length; i++)
        {
            Sub(i, i, s);
            Sub(i, i+1, s);
        }
        
        return count;
    }

    public void Sub(int l, int r, string s)
    {
            while(l>=0 && r<s.Length && s[l]==s[r])
            {
                count++;
                l--;
                r++;
            }
    }
}
