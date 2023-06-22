using System;
namespace Leetcode_2023
{
	public class LT_79_Word_Search
	{
		public LT_79_Word_Search()
		{
		}
        public bool Exist(char[][] board, string word)
        {
			int row = board.Length;
			int col = board[0].Length;
			List<string> path = new System.Collections.Generic.List<string>();

            bool dfs(int r, int c, int i)
            {
                if (i == word.Length)
                    return true;
                if (r < 0 || c < 0 ||
                    r >= row || c >= col ||
                    word[i] != board[r][c] ||
                    path.Contains(r + "," + c))
                    return false;
                path.Add(r + "," + c);
                bool ret = (dfs(r + 1, c, i + 1) ||
                    dfs(r - 1, c, i + 1) ||
                    dfs(r, c + 1, i + 1) ||
                    dfs(r, c - 1, i + 1));
                path.Remove(r + "," + c);
                return ret;
            }


            for (int rowLoop = 0; rowLoop < board.Length; rowLoop++)
				for (int colLoop = 0; colLoop < board[rowLoop].Length; colLoop++)
					if (dfs(rowLoop, colLoop, 0))
						return true;
			return false;
        }
		public bool dfs(int r, int c, int i,int row, int col, string word, char[][] board, List<string> path)
		{
			if (i == word.Length)
				return true;
			if (r < 0 || c < 0 ||
				r >= row || c >= col ||
				word[i] != board[r][c] ||
				path.Contains(r + "," + c))
				return false;
			path.Add(r + "," + c);
			bool ret = (dfs(r + 1, c, i + 1, row, col, word, board, path) ||
				dfs(r - 1, c, i + 1, row, col, word, board, path) ||
				dfs(r, c+1, i + 1, row, col, word, board, path) ||
				dfs(r, c-1, i + 1, row, col, word, board, path));
            path.Remove(r + "," + c);
			return ret;
		}
    }
}

