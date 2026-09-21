public class Solution {
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int rows = heights.Length;
        int cols = heights[0].Length;

        bool[,] pacific = new bool[rows, cols];
        bool[,] atla = new bool[rows, cols];

        List<List<int>> list = new List<List<int>>();

        // Loop through Pacfic
        for(int j=0; j<cols;j++)
        {
            DFS(0, j, heights[0][j], pacific, heights);
        }

        for(int i=0; i<rows; i++)
        {
            DFS(i, 0, heights[i][0], pacific, heights);
        }

        // loop through Atla
        for(int i=0; i<rows;i++)
        {
            DFS(i, cols-1, heights[i][cols-1], atla, heights);
        }


        for(int j=0; j<cols;j++)
        {
            DFS(rows-1, j, heights[rows-1][j], atla, heights);
        }

        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<cols;j++)
            {
                if(pacific[i,j]&&atla[i,j])
                    list.Add(new List<int>{i,j});
            }
        }

        return list;
  
    }

    public void DFS(int r, int c, int prevh, bool[,] visited, int[][] heights)
    {
        if(r<0 || r>=heights.Length || c<0 || c>=heights[0].Length)
        {
            return;
        }

        // visited, return
        if(visited[r, c])
        {
            return;
        }

        if(heights[r][c]<prevh)
        {
            return;
        }

        //mark visited
        visited[r, c] = true;

        DFS(r+1, c, heights[r][c], visited, heights);
        DFS(r-1, c, heights[r][c], visited, heights);
        DFS(r, c+1, heights[r][c], visited, heights);
        DFS(r, c-1, heights[r][c], visited, heights);
    }
}
