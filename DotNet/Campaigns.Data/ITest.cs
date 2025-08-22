public interface ITest
{
  public interface IThing
  {
    string Name => "Default";
    string OtherName { get; }
  }
}