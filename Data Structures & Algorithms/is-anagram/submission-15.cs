public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var dir = new Dictionary<char, int>();
        foreach(var i in s)
        {
            dir[i]=dir.GetValueOrDefault(i)+1;
        }
        foreach(var i in t)
        {
            if (!dir.ContainsKey(i))
                return false;
            dir[i]--;
            if(dir[i]<0)
                return false;
            
        }
        return true;

    }
}
