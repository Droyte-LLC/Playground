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

/*
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
*/

using Campaigns.Data.Interfaces;
using Interviews.Coding;

//Console.WriteLine("AccessibilityTester class is defined in another assembly");
//Check check = new Check();

Console.WriteLine("Because Foo is hidden in the Derived class, when cast to MyBase, it will output MyBase's version because it was never overrided.");
MyBase obj = new Derived();
obj.Foo();

Console.WriteLine("Child overrides Parent's Name therefore, casting to Parent shows Parent's version");
Console.WriteLine(((Parent)new Child()).Name);

Console.WriteLine("Child overrides Parent's Name therefore will show Child's Name");
Console.WriteLine(new Child().Name);

Console.WriteLine("B overrides A and C hides B");
Console.WriteLine("A obj2 = new C();  ––> obj2.Say(); ––> Expecting B");
A obj2 = new C();
obj2.Say();

Console.WriteLine("((C)obj2).Say(); ––> Expecting C");
((C)obj2).Say();

List<int> numbers = new List<int>
{
  5, 3, 8, 3, 1, 5, 8, 5, 3, 9,
  2, 2, 2, 9, 4, 4, 4, 4, 6, 7,
  6, 7, 7, 7, 8, 8, 8, 8, 9, 9
};

Console.WriteLine($"original list: {System.Text.Json.JsonSerializer.Serialize(numbers.ToList())}");
Console.WriteLine("After calling Coding.GetSortedOccurrenceDictionary(numbers)");
Console.WriteLine($"results: {Coding.GetSortedOccurrenceDictionary(numbers)}");

public class A
{
  public virtual void Say() => Console.WriteLine("A");
}

public class B : A
{
    public override void Say() => Console.WriteLine("B");
}

public class C : B
{
    public new void Say() => Console.WriteLine("C");
}

public abstract class MyBase
{
  public virtual void Foo()
  {
    Console.WriteLine("MyBase.Foo");
  }

  public abstract void Bar();
}

public class Derived : MyBase
{
  public override void Bar()
  {
    Console.WriteLine("Derived.Bar");
  }
  public new void Foo()
  {
    Console.WriteLine("Derived.Foo");
  }
}

public class Parent
{
    public virtual string Name => "Parent";
}

public class Child : Parent
{
    public new string Name => "Child";
}


public class Check : TestCamp
{
}

//Console.WriteLine($"I can access top level class if it has the following access modifier: public");