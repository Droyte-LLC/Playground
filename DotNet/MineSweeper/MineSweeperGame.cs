namespace MineSweeper;

public class MineSweeperGame
{
  private char[,] board;
  private int rows;
  private int cols;
  private int mines;
  private bool gameOver;

  public MineSweeperGame(char[,] board)
  {
    this.board = board;
    this.rows = board.GetLength(0);
    this.cols = board.GetLength(1);
    this.mines = GetMinesCount();
  }

  public MineSweeperGame()
  {
    this.board = new char[,]
    {
      { 'E', 'E', 'E', 'M', 'E', 'E', 'E', 'E' },
      { 'E', 'M', 'E', 'E', 'E', 'E', 'E', 'E' },
      { 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'M' },
      { 'M', 'E', 'E', 'E', 'E', 'E', 'E', 'E' },
      { 'E', 'E', 'E', 'E', 'M', 'M', 'E', 'M' },
      { 'E', 'E', 'M', 'M', 'E', 'E', 'M', 'M' },
      { 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E' },
      { 'E', 'E', 'E', 'E', 'M', 'E', 'E', 'E' }
    };

    this.rows = board.GetLength(0);
    this.cols = board.GetLength(1);
    this.mines = GetMinesCount();
    this.gameOver = false;
  }

  private int GetMinesCount()
  {
    int mines = 0;

    foreach (char c in board)
    {
      if (c == 'M')
      {
        mines++;
      }
    }

    return mines;
  }
  public char[,] GetBoard()
  {
    return board;
  }

  private int[][] directions =
  [
    [-1, -1], [-1, 0], [-1, 1], [0, 1], [1, 1], [1, 0], [1, -1], [0, -1]
  ];

  public bool IsGameOver()
  {
    return gameOver;
  }

  public bool IsGameWon()
  {
    int clearedCells = 0;
    foreach (char c in board)
    {
      if (c != 'E' && c != 'M')
        clearedCells++;
    }
    return clearedCells == (rows * cols - mines);
  }

  public void UpdateBoard(int clickedRow, int ClickedCol)
  {
    if (board[clickedRow, ClickedCol] == 'M')
    {
      board[clickedRow, ClickedCol] = 'X';
      this.gameOver = true;
      return;
    }

    Queue<(int, int)> queue = new Queue<(int, int)>();
    queue.Enqueue((clickedRow, ClickedCol));
    bool[,] visited = new bool[rows, cols];

    while (queue.Count > 0)
    {
      var (r, c) = queue.Dequeue();

      if (visited[r, c])
      {
        continue;
      }

      visited[r, c] = true;

      int mines = CountAdjacentMines(r, c);
      if (mines > 0)
      {
        board[r, c] = (char)(mines + '0');
      }
      else
      {
        board[r, c] = 'B';
        foreach (var dir in directions)
        {
          int nr = r + dir[0];
          int nc = c + dir[1];
          if (InBounds(nr, nc) && board[nr, nc] == 'E')
            queue.Enqueue((nr, nc));
        }
      }
    }

    if (IsGameWon())
    {
      gameOver = true;
    }
  }

  int CountAdjacentMines(int row, int col)
  {
    int count = 0;
    foreach (var dir in directions)
    {
      int r = row + dir[0];
      int c = col + dir[1];
      if (InBounds(r, c) && board[r, c] == 'M')
        count++;
    }
    return count;
  }

  bool InBounds(int r, int c)
  {
    return r >= 0 && r < rows && c >= 0 && c < cols;
  }

  public void ShowBoard()
  {
    for (int r = 0; r < rows; r++)
    {
      for (int c = 0; c < cols; c++)
        Console.Write(board[r, c] + " ");
      Console.WriteLine();
    }
  }
}
