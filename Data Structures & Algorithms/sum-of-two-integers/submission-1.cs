public class Solution {
    public int GetSum(int a, int b) {
        
        int c = (a & b) << 1;
        int s = a ^ b;
        while(c!=0)
        {
            a=s;
            b=c;
            c = (a & b) << 1;
            s = a ^ b;
        }
        return s;
    }
}
