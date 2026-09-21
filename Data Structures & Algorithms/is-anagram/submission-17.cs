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
            if(!dir.TryGetValue(i, out int count) || count==0)
                return false;
            else
                dir[i]--;
            
        }
        return true;

    }
}
