public class Solution {


    Dictionary<int, int> dir = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount) {
        int ans = Sum(coins, amount);

        if(ans==int.MaxValue)
            return -1;
        
        return ans;
        
    }

    public int Sum(int[] coins, int amount)
    {
        if(amount==0)
            return 0;
        if(amount<0)
            return int.MaxValue;
        
        if(dir.TryGetValue(amount, out int min))
        {
            return min;
        }

        min = int.MaxValue;

        foreach(int coin in coins)
        {
            int res = Sum(coins, amount-coin);
            
            if(res != int.MaxValue)
                min=Math.Min(min, 1+res);
        }
        
        dir[amount]=min;
        return min;
    }
}
