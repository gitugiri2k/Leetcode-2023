
using System;
namespace Leetcode_2023
{
	public class LT_200_Number_of_Islands
	{
		public LT_200_Number_of_Islands()
		{
		}
        public int NumIslands(char[][] grid)
        {
			if (grid is null)
				return 0;
			int r = grid.Length;
			int c = grid[0].Length;
            bool[,] visited = new bool[r, c];
			int island = 0;
			void dfs(int row,int col)
			{
				if (row >= r ||
					row<0||
					col<0||
					col >= c ||
					grid[row][col] != '1' ||
					visited[row, col])
					return;
				visited[row, col] = true;
				dfs(row + 1, col);
                dfs(row - 1, col);
                dfs(row, col+1);
                dfs(row, col-1);
            }
            for (int i = 0; i < r; i++)
			{
				for (int j = 0; j < c; j++)
				{
					if (grid[i][j] == '1' && !visited[i,j])
					{
						dfs(i,j);
                        island += 1;
                    }
                }
			}
			return island;
        }
    }
}

