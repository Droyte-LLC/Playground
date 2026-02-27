from typing import List
class Minesweeper:

  def __init__(self, board: list[list[str]] | None = None, rows: int = 0, cols: int = 0):
    """
    Minesweeper Init
    """
    self._board = board if board is not None else []
    self._rows = len(board)
    self._cols = len(board[0]) if board else cols
    self._mines = self.getMinesCount()
    self._directions: list[list[int]] = [-1, -1], [-1, 0], [-1, 1], [0, 1], [1, 1], [1, 0], [1, -1], [0, -1]
    self._gameOver: bool = False

  def isGameWon(self) -> bool:
    clearedCells = sum(cell == "E" for rows in self._board for cell in rows)
    return clearedCells == self._rows * self._cols
    

  def updateBoard(self) -> None:
    pass

  def showBoard(self) -> None:
    pass

  def isInbound(self) -> bool:
    pass

  def countAdjacentMines(self, row: int, col: int) -> int:
    pass

  def getMinesCount(self) -> int:
    """Iterate over the board and return the number of 'M' cells."""
    return sum(cell == 'M' for row in self._board for cell in row)
    
  def play(self):
    """
    Minesweeper's play function
    """
    print(f"Welcome to Minesweeper!")

game = Minesweeper()

game._board = [
  [ 'E', 'E', 'E', 'M', 'E', 'E', 'E', 'E' ],
  [ 'E', 'M', 'E', 'E', 'E', 'E', 'E', 'E' ],
  [ 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'M' ],
  [ 'M', 'E', 'E', 'E', 'E', 'E', 'E', 'E' ],
  [ 'E', 'E', 'E', 'E', 'M', 'M', 'E', 'M' ],
  [ 'E', 'E', 'M', 'M', 'E', 'E', 'M', 'M' ],
  [ 'E', 'E', 'E', 'E', 'E', 'E', 'E', 'E' ],
  [ 'E', 'E', 'E', 'E', 'M', 'E', 'E', 'E' ]
]

game.play()
print(f"is game won? {game.isGameWon()}")