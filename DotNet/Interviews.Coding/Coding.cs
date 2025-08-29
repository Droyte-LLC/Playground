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

  /*
4
aba
baba
aba
xzxb
3
aba
xzxb
ab
  */

  public static List<int> matchingStrings(List<string> stringList, List<string> queries)
  {
    List<int> results = new();

    //get frequency count
    Dictionary<string, int> frequencyCount = new();

    for (int i = 0; i < queries.Count; i++)
    {
      if (stringList.Contains(queries[i]))
      {
        if (frequencyCount.ContainsKey(queries[i]))
        {
          frequencyCount[queries[i]] = frequencyCount[queries[i]] + 1;
        }
        else
        {
          frequencyCount.Add(queries[i], 1);
        }
      }
      else
      {
        frequencyCount.Add(queries[i], 0);
      }
    }

    for (int i = 0; i < queries.Count; i++)
    {
      if (frequencyCount.ContainsKey(queries[i]))
      {
        results.Add(frequencyCount[queries[i]]);
      }
      else
      {
        results.Add(0);
      }
    }

    return results;
  }
}
