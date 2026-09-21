public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var dir1 = new Dictionary<char, int>();
        var dir2 = new Dictionary<char, int>();
        foreach(var i in s)
        {
            dir1[i]=dir1.GetValueOrDefault(i)+1;
        }
        foreach(var i in t)
        {
            dir2[i]=dir2.GetValueOrDefault(i)+1;
            
        }
        
        foreach (var kv in dir1)
        {
            if(!dir1.ContainsKey(kv.Key) || !dir2.ContainsKey(kv.Key) || dir1[kv.Key]!=dir2[kv.Key])
                return false;
        }
        return true;

    }
}
