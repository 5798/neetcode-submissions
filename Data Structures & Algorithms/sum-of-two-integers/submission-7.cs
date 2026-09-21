public class Solution {
    public int GetSum(int a, int b) {
        
        while(b!=0)
        {
            int s = (a^b);
            int c = (a&b)<<1;
            a=s;
            b=c;
        }
        return a;
    }
}
