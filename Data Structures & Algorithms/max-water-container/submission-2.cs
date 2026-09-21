public class Solution {
    public int MaxArea(int[] heights) {
        int i=0;
        int j= heights.Length-1;
        int max = 0;
        while(i<j)
        {
            max = Math.Max(max, Math.Min(heights[i], heights[j]) * (j-i));
            if(heights[i]<heights[j])
                i++;
            else
                j--;
        }
        return max;
    }
}
