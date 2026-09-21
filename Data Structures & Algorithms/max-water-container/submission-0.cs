public class Solution {
    public int MaxArea(int[] heights) {
        int i=0;
        int j= heights.Length-1;
        int max = 0;
        while(i<j)
        {
            int p = Math.Min(heights[i], heights[j]) * (j-i);
            if(p >max)
            {
                max=p;
            }
            if(heights[i]<heights[j])
                i++;
            else if(heights[i]>heights[j])
                j--;
            else
                i++;
        }
        return max;
    }
}
