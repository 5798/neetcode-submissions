public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;

        Queue<(int r, int c)> q = new();

        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                if(grid[i][j]==0)
                    q.Enqueue((i,j));
            }
        }

        int[][] dir = {
            new int[] {-1,0}, //up
            new int[] {1,0}, //down
            new int[] {0,-1}, //left
            new int[] {0,1} //right
        };

        while(q.Count>0)
        {
            var (r, c) = q.Dequeue();
            foreach(var d in dir)
            {
                var nr = d[0]+r;
                var nc = d[1]+c;

                if(nr<0 || nr>=row || nc<0 || nc>=col)
                    continue;
                
                if(grid[nr][nc]==-1)
                    continue;

                if(grid[nr][nc]!=int.MaxValue)
                    continue;
                
                grid[nr][nc] = grid[r][c]+1;

                q.Enqueue((nr,nc));
            }
        }
    }
}
