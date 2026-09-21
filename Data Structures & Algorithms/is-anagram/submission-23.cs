public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var arr = new int[26];
        foreach(var i in s)
        {
            arr[i-'a']++;
        }
        foreach(var i in t)
        {
            if(--arr[i-'a'] <0)
                return false;
        }
        return true;
        

    }
}
