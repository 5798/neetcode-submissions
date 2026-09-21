public class Solution {
    Dictionary<int, int> memo = new Dictionary<int, int>();

    public int NumDecodings(string s) {
        if(s.Length==0)
            return 0;

        return Decode(0, s);
    }

    public int Decode(int i, string s)
    {
        if(i == s.Length)
            return 1;

        if(s[i] == '0')
            return 0;
        
        if(memo.TryGetValue(i, out int ways))
            return ways;
        
        ways = Decode(i+1, s);

        if((i+1 < s.Length) && (s[i]=='1' || (s[i] == '2' && s[i+1]<='6')))
        {
            ways = ways + Decode(i+2, s);
        }

        memo[i]=ways;

        return ways;
       
    }
}
