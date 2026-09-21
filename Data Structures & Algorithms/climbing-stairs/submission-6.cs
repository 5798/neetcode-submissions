public class Solution {
    Dictionary<int, int> dir  = new Dictionary<int, int>();
    public int ClimbStairs(int n) {

        if(n==0)
            return 0;
        if(n==1)
            return 1;
        if(n==2)
            return 2;
     

        if(dir.TryGetValue(n, out int c))
        {
            return c;
        }

        c = ClimbStairs(n-1) + ClimbStairs(n-2);
        dir[n] = c;

        return c;
    
    }
}
