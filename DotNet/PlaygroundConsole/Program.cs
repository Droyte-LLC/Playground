// Console.WriteLine("Testing CampaignDbContextFactory!");

// var factory = new CampaignDbContextFactory();
// var context = factory.CreateDbContext(args);

//Console.WriteLine("Connection successful.");

//Console.ReadLine();


// PlaygroundConsole
// Console.WriteLine("Welcome to PlaygroundConsole, let's play Minesweeper!");
// MineSweeperGame sweeperGame = new();

// Console.WriteLine("\nGood luck! Try not to hit a mine...");

// sweeperGame.ShowBoard();

// while (!sweeperGame.IsGameOver())
// {
//   Console.WriteLine("Enter the row and column of the cell you want to click.  Example: 2 3");
//   string? input = Console.ReadLine();
//   string[] parts = input?.Split(' ') ?? Array.Empty<string>();

//   if (parts.Length != 2 || !int.TryParse(parts[0], out int row) || !int.TryParse(parts[1], out int col))
//   {
//     Console.WriteLine("Please enter two valid numbers, separated by a space.  Example: 2 3");
//     continue;
//   }

//   sweeperGame.UpdateBoard(row, col);
//   sweeperGame.ShowBoard();
// }

// if (sweeperGame.IsGameWon())
//   Console.WriteLine("Congratulations! You cleared the board without hitting a mine!");
// else
//   Console.WriteLine("Game Over! You hit a mine.  Thank you for playing!");

#region Threading Example
Example1.Run();

Thread anotherThread = new Thread(() =>
{
  Console.WriteLine($"{Thread.CurrentThread.Name} running in parallel ...");
  Thread.Sleep(14000); // Simulate some work
  Console.WriteLine($"{Thread.CurrentThread.Name} has finished its work!");
});

anotherThread.Name = "[Other-T]";
anotherThread.Start();
anotherThread.Join(); // Wait for the thread to finish

Console.WriteLine("[Main] is continuing after anotherThread has finished.");

#endregion