public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dir = new Dictionary<string, List<string>>();
        var final = new List<List<string>>();
        foreach(var s in strs)
        {
            string key = Freq(s);
            if(dir.ContainsKey(key))
            {
                dir[key].Add(s);
            }
            else
            {
                dir[key]= new List<string>{s};
            }
        }

        foreach(var d in dir.Values)
        {
            final.Add(d);
        }
        return final;
    }

    private string Freq(string s)
    {
        var freq = new int[26];
        foreach(var ch in s)
        {
            freq[ch-'a']++;
        }
        return string.Join("#", freq);
    }
}
