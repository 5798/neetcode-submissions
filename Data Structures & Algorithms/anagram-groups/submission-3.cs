public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var d = new Dictionary<string, List<string>>();

        foreach(var i in strs)
        {
            var n = new int[26];
            foreach(var j in i)
            {
                n[j-'a']++;
            }

            var key = string.Join("#", n);

            if(!d.ContainsKey(key))
            {
                d[key]=new List<string>();
            }
            d[key].Add(i);
        }

        var final = new List<List<string>>();
        foreach(var i in d.Values)
        {
            final.Add(i);
        }
        return final;
    }
}
