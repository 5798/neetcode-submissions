public class Solution {
    public bool Exist(char[][] board, string word) {
        for(int r=0; r<board.Length; r++)
        {
            for(int c=0; c<board[0].Length ;c++)
            {
                if(DFS(r,c,0,board, word))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public bool DFS(int r, int c, int index, char[][] board, string word)
    {
        if(index == word.Length)
            return true;

        if(index > word.Length)
            return false;
        

        if(r< 0 || r>=board.Length || c<0 || c>=board[0].Length)
            return false;
        
        if(board[r][c] != word[index])
            return false;
        
        var temp = board[r][c];
        board[r][c] = '#';

        var found = DFS(r-1, c, index+1, board, word) || DFS(r+1, c, index+1, board, word) || DFS(r, c-1, index+1, board, word) || DFS(r, c+1, index+1, board, word);
        
        board[r][c] = temp;

        return found;
    }
}
