/*
  Instructions:

  The program starts with an empty container.

  ADD <value> should add the specified integer value to the container.

  DELETE <value> should attempt to remove the specified integer value from the container. 
  If the value is present in the container, remove it and return true, otherwise, return false.

  GET_MEDIAN should return the median integer.
  The integer value in the middle of the sequence after all integer value stored in the container 
  are sorted from smallest to largest. 

  If the length of the sequence is even, the leftmost integer from the two middle integers should be returned. 
  If the container is empty, this method should raise a runtime exception.  
*/

const queries = [
  ['ADD', '1'],
  ['ADD', '2'],
  ['ADD', '5'],
  ['ADD', '2'],
  ['EXISTS', '2'],
  ['EXISTS', '5'],
  ['EXISTS', '1'],
  ['EXISTS', '4'],
  ['EXISTS', '3'],
  ['EXISTS', '0'],
];

const processQueries = (queries: string[][]): string[] => {
  let container: string[] = [];
  let results: string[] = [];

  for (const [key, [k, v]] of queries.entries()) {
    if (k == 'ADD') {
      container.push(v);
      results.push('');
    }

    if (k == 'EXISTS') {
      if (container.includes(v)) {
        results.push('true');
      } else {
        results.push('false');
      }
    }
  }

  return results;
};

console.log(`after processing queries: ${processQueries(queries)}`);