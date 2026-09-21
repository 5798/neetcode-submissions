public class Solution {
    public string MinWindow(string s, string t) {
        var n1 = new Dictionary<char, int>();
        var n2 = new Dictionary<char, int>();
        int l=0;
        int bestl=0;
        int min=int.MaxValue;
        for(int i=0;i<t.Length;i++)
        {
            if (n1.TryGetValue(t[i], out int count))
                n1[t[i]] = count + 1;
            else
                n1[t[i]] = 1;
        }
        for(int r=0; r<s.Length ; r++)
        {
            bool valid=true;
            
            if (n2.TryGetValue(s[r], out int count))
                n2[s[r]] = count + 1;
            else
                n2[s[r]] = 1;

            foreach(var kv in n1)
            {
                if(!n2.TryGetValue(kv.Key, out int d) || d<kv.Value)
                {    
                    valid=false;
                    break;
                }
            }
            while(valid)
            {
                if(r-l+1 < min)
                {
                    min = r-l+1;
                    bestl=l;
                }
                n2[s[l]]--;
                l++;
                foreach(var kv in n1)
                {
                    if(!n2.TryGetValue(kv.Key, out int d) || d<kv.Value)
                    {    
                        valid=false;
                        break;
                    }
                }
            }
        }

        if(min == int.MaxValue)
            return "";
        return s.Substring(bestl, min);
    }
}
