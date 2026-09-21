public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var dir = new Dictionary<string,List<string>>();
        foreach(var s in strs)
        {
            var n = new int[26];
            foreach(var i in s)
            {
                n[i-'a']++;
            }
            string id = string.Join("#", n);
            if(!dir.TryGetValue(id, out var ss))
            {
                ss=new List<string>();
                dir.Add(id,ss);
            }
            ss.Add(s);
        }
        return dir.Values.ToList();
    }
}
