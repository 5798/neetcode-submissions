public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var s in strs)
        {
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }
        return sb.ToString();
    }   

    public List<string> Decode(string s) {
        StringBuilder sb = new StringBuilder();
        var ss = new List<string>();

        
        for(int i=0;i<s.Length; i++)
        {
            int n=0;
            while(s[i]!='#')
            {
                if(char.IsDigit(s[i]))
                {
                    n = n*10+s[i]-'0';
                }
                i++;
            }

            while(n>0 && i<s.Length)
            {
                i++;
                n--;
                sb.Append(s[i]);

            }
            ss.Add(sb.ToString());

            sb.Clear();

            n=0;
        }
        return ss;
   }
}
