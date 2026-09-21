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
            if(dir.ContainsKey(id))
            {
                dir[id].Add(s);
            }
            else
            {
                dir.Add(id, new List<string>{s});
            }
        }
        return dir.Values.ToList();
    }
}
