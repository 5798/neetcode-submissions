public class Solution {
    public int OrangesRotting(int[][] grid) {
        int row = grid.Length;
        int col = grid[0].Length;
        int count = 0;
        int fresh = 0;

        Queue<(int r, int c)> q = new();

        for(int i=0;i<row;i++)
        {
            for(int j=0;j<col;j++)
            {
                if(grid[i][j]==2)
                    q.Enqueue((i, j));
                if(grid[i][j]==1)
                    fresh++;
            }
        }

        int[][] dir = 
        {
            new int[] {-1, 0}, // top
            new int[] {1, 0}, // down
            new int[] {0, -1}, // left
            new int[] {0, 1} // right
        };

        while(q.Count>0)
        {
            int size = q.Count;
            for(int i =0;i<size;i++)
            {
                var (r, c) = q.Dequeue();

                foreach(var d in dir)
                {
                    int nr = d[0]+r;
                    int nc = d[1]+c;

                    if(nr<0 || nr>=row || nc<0 || nc>=col)
                        continue;
                    
                    if(grid[nr][nc]==0)
                        continue;

                    if(grid[nr][nc]==2)
                        continue;

                    grid[nr][nc] = 2;
                    fresh--;

                    q.Enqueue((nr, nc));
                }
            }
            if(q.Count>0)
                count++;
        }

        if(fresh==0)
        {
            return count;
        }
        else
            return -1;
    }
}
