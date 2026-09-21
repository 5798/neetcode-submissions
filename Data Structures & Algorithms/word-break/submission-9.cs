public class Solution {
    Dictionary<int, bool> dir = new Dictionary<int, bool>();
    HashSet<string> words = new HashSet<string>();
    public bool WordBreak(string s, List<string> wordDict) {
        words = new HashSet<string>(wordDict);

        return Break(0, s);
    }

    public bool Break(int i, string s)
    {
        if(i==s.Length)
            return true;
        
        if(dir.TryGetValue(i, out bool b))
        {
            return b;
        }

        for(int j=i+1; j<=s.Length; j++)
        {
            string word = s.Substring(i, j-i);

            if(words.Contains(word))
            {
                if(Break(j,s))
                {
                    dir[i]=true;
                    return true;
                }
            }
        }

        dir[i]=false;
        return false;
    }
}
