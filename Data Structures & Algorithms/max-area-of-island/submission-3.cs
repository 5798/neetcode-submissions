public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;

        for(int r=0; r<grid.Length; r++)
        {
            for(int c=0; c<grid[0].Length ;c++)
            {
                if(grid[r][c]==1)
                {
                    max = Math.Max(max, DFS(r,c,grid));
                }
            }
        }
        return max;
    }

    public int DFS(int r, int c, int[][] grid)
    {
        if(r<0 || r>=grid.Length || c<0 || c>=grid[0].Length)
            return 0;
        if(grid[r][c] == 0)
            return 0;

        grid[r][c]=0;
        
        return 1 + DFS(r+1, c, grid)+DFS(r-1, c, grid)+DFS(r, c+1, grid)+DFS(r, c-1, grid);
        
    }
}
