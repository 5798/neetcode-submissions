public class Solution {
    public int GetSum(int a, int b) {
        
        while(b!=0)
        {
            int c = (a & b) << 1;
            int s = a ^ b;
            a=s;
            b=c;
        }
        return a;
    }
}
