public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        var dict = new Dictionary<char, int>();
        foreach(var x in s)
        {
            if(dict.ContainsKey(x))
                dict[x]++;
            else
                dict[x]=1;
        }

        foreach(var x in t)
        {
            if(dict.ContainsKey(x))
                dict[x]--;
            else
                return false;
        }

        foreach(var k in dict)
        {
            if(k.Value!=0)
                return false;
        }
        return true;

        

    }
}
