public class Solution {
    Dictionary<int, int> dir  = new Dictionary<int, int>();
    public int ClimbStairs(int n) {

        if(n==0)
            return 0;
        if(n==1)
            return 1;
        if(n==2)
            return 2;
        else
        {
            if(!dir.TryGetValue(n-1, out int c1))
            {
                c1 = ClimbStairs(n-1);
                dir[n-1] = c1;
            }
            if(!dir.TryGetValue(n-2, out int c2))
            {
                c2 = ClimbStairs(n-2);
                dir[n-2] = c2;
            }

            return  (c1+c2);
        }
    }
}
