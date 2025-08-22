namespace Campaigns.Data.Interfaces;

public interface ITesterMode
{
  string Name { get; }
}
public interface IAccessibilityTester
{
  void Test();
}