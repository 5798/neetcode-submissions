public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(var i in strs)
        {
            sb.Append(i.Length);
            sb.Append("#");
            sb.Append(i);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var ss = new List<string>();
        int c=0;
        StringBuilder sb = new StringBuilder();

        for(int i=0;i<s.Length;i++)
        {
           
            while(s[i]!='#')
            {
                if(char.IsDigit(s[i]))
                {
                    c=c*10+s[i]-'0';
                }
                i++;
            }
            while(c>0 && i<s.Length)
            {
                i++;
                c--;
                
                sb.Append(s[i]);
            }
            ss.Add(sb.ToString());
            sb.Clear();
            c=0;
        }
        
            return ss;
   }
}
