public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length, cols = grid[0].Length;
        int islands = 0;

        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == '1') {
                    Bfs(grid, r, c);
                    islands++;
                }
            }
        }
        return islands;
    }
    private readonly int[][] directions = new int[][] { new int[] { 1, 0 }, new int[] { -1, 0 },
                                                        new int[] { 0, 1 }, new int[] { 0, -1 } };
    public void Bfs(char[][] grid, int r, int c) {
        Queue<int[]> queue = new();
        grid[r][c] = '0';
        queue.Enqueue(new int[] { r, c });
        while (queue.Count > 0) {
            var node = queue.Dequeue();
            int row = node[0], col = node[1];

            foreach (var dir in directions) {
                int nr = row + dir[0], nc = col + dir[1];
                if (nr >= 0 && nc >= 0 && nr < grid.Length && nc < grid[0].Length &&
                    grid[nr][nc] == '1') {
                    queue.Enqueue(new int[] { nr, nc });
                    grid[nr][nc] = '0';
                }
            }
        }
    }
}
