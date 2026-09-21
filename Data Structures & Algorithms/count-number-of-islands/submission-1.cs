public class Solution {
    public int NumIslands(char[][] grid) {
        int count=0;
        for(int r=0; r<grid.Length; r++)
        {
            for(int c=0;c<grid[0].Length;c++)
            {
                if(grid[r][c]=='1')
                {
                    count++;
                    DFS(r,c,grid);
                }
            }
        }
        return count;
    }

    public void DFS(int r, int c, char[][] grid)
    {

        if(r<0 || r>=grid.Length || c<0 || c>=grid[0].Length)
            return;
        
        if(grid[r][c] == '0')
            return;

        grid[r][c]='0';

        DFS(r+1, c, grid);
        DFS(r-1, c, grid);
        DFS(r, c+1, grid);
        DFS(r, c-1, grid);
    }
}
