public class Solution {
    public bool IsPalindrome(string s) {
        int i =0;
        int j = s.Length-1;
        while(i<j)
        {
            if(!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }
            else if(!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }

            if(Char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }
            i++;
            j--;

        }
        return true;
    }
}
