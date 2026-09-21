public class Solution {
    string ss=null;
    public string LongestPalindrome(string s) {
        int l=0;
        int r=0;
        for(int i=0;i< s.Length; i++)
        {
            l=i;
            r=i;
            Expand(i,i, s);
            Expand(i, i+1, s);
    
        }
        return ss;
    }

    public void Expand(int l, int r, string s)
    {
        while(l>=0 && r<s.Length)
            {
                if(s[l]==s[r])
                {
                    if(string.IsNullOrEmpty(ss) || r-l+1 >ss.Length){
                        ss = s.Substring(l, r-l+1);
                    }
                    l--;
                    r++;
                }
                else
                {
                    break;
                }
            }
    }
}
