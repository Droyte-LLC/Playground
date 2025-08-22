namespace Interviews.Coding;

public class Coding
{
  public static int Add(int a, int b)
  {
    return a + b;
  }

  public static Dictionary<int, int> GetSortedOccurrenceDictionary(List<int> list)
  {
    var frequencyDict = list
        .GroupBy(n => n)
        .OrderBy(g => g.Count())   // Sort by count ascending
        .ThenBy(g => g.Key)        // Then by number ascending
        .ToDictionary(g => g.Key, g => g.Count());

    // Output the sorted dictionary
    foreach (var kvp in frequencyDict)
    {
      Console.WriteLine($"Number: {kvp.Key}, Count: {kvp.Value}");
    }

    return frequencyDict;
  }
}
