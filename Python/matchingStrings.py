#Convert c# to python

list_strings = ["aba", "baba", "aba", "xzxb"]
queries = ["aba","xzxb","ab"]

def matchingString(list_strings: list[str], queries: list[str]) -> list[int]:
  results: list[int] = []
  frequencyCount: dict[str, int] = {}

  # Build frequency count
  for word in list_strings:
      frequencyCount[word] = frequencyCount.get(word, 0) + 1

  # Count occurrences for each query
  for query in queries:
    results.append(frequencyCount.get(query, 0))

  # Example of how I could have used range to iterate
  # for i in range(len(queries)):
  #   results.append(frequencyCount.get(queries[i], 0))

  return results


print(f"matchingString results are: {matchingString(list_strings, queries)}")