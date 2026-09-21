public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var d = new Dictionary<char,int>();
        foreach(var i in s)
        {
            if(d.ContainsKey(i))
            {
                d[i]++;
            }
            else
            {
                d[i]=1;
            }
        }

        foreach(var i in t)
        {
            if(!d.ContainsKey(i)|| d[i]==0)
                return false;
            else
                d[i]--;
        }

        return true;   
    }
}
