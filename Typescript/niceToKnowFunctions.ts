console.log('\n.repeat()')
console.log('---------')
console.log(`'a'.repeat(3) -> '${'a'.repeat(3)}'`) // "aaa"

console.log('\n.slice()')
console.log('--------')
console.log()
console.log(`'hello'.slice(1, 4) -> '${'hello'.slice(1, 4)}'`) // "ell"
console.log(`'hello'.slice(-2) -> '${'hello'.slice(-2)}'`) // "lo"
console.log(`'poubelle'.slice(-5) -> '${'poubelle'.slice(-5)}'`) // "belle"
console.log(`'implementation.slice(2,7) -> '${'implementation'.slice(2, 7)}'`) // "pleme"

console.log('\n.substring(start, end)')
console.log('----------------------')
console.log(`'hello'.substring(1, 4) -> '${'hello'.substring(1, 4)}'`) // "ell"
console.log(`'pizza'.substring(1, 2) -> '${'pizza'.substring(1, 2)}'`) // "i"

console.log('\n.trim(), .trimStart(), .trimEnd()')
console.log('---------------------------------')
console.log(`'  test  '.trim() -> '${'  test  '.trim()}'`) // "test"
console.log(`'\n test'.trimStart() -> '${'\n test'.trimStart()}'`) // "test"
console.log(`'data  \n'.trimEnd() -> '${'data  \n'.trimEnd()}'`) // "data"
console.log(`'   bebe lala ..   '.trim() -> '${'   bebe lala ..   '.trim()}'`) // "bebelala.."

console.log('\n.padStart(), .padEnd()')
console.log('----------------------')
console.log(`'7'.padStart(3, '0') -> '${'7'.padStart(3, '0')}'`) // "007"
console.log(`'hi'.padEnd(5, '.') -> '${'hi'.padEnd(5, '.')}'`) // "hi..."

console.log('\n.includes()')
console.log('-------------')
console.log(`'apples'.includes('ple') -> '${'apples'.includes('ple')}'`) // true

console.log('\n.startsWith(), .endsWith()')
console.log(`'apples'.startsWith('app') -> '${'apples'.startsWith('app')}'`); // true
console.log(`'apples'.endsWith('es') -> '${'apples'.endsWith('es')}'`); // true

console.log('.indexOf(), .lastIndexOf()')
console.log('--------------------------')
console.log(`'banana'.indexOf('a') -> '${'banana'.indexOf('a')}'`) // 1
console.log(`'banana'.lastIndexOf('a') -> '${'banana'.lastIndexOf('a')}'`) // 5

console.log('\n.replace(), .replaceAll()')
console.log('--------------------------')
console.log(`'abcabc'.replace('a', 'x') -> '${'abcabc'.replace('a', 'x')}'`); // "xbcabc"
console.log(`'abcabc'.replaceAll('a', 'x') -> '${'abcabc'.replaceAll('a', 'x')}'`); // "xbcxbc"
console.log(`'apple123'.replace(/\\d+/g, '') -> '${'apple123'.replace(/\d+/g, '')}'`); // "apple"


console.log('\n.match() (regex search)')
console.log('--------------------------')
console.log(`'abc123'.match(/\\d+/) -> '${'abc123'.match(/\d+/)}'`); // ["123"]
console.log(`'abc123'.match(/\\d+/g) -> '${'abc123'.match(/\d+/g)}'`); // ["123"]


console.log('\n.matchAll() (returns iterator)')
console.log('--------------------------')
console.log([...('a1b2c3'.matchAll(/\d/g))]); // [["1"], ["2"], ["3"]]
console.log('a1b2c3'.matchAll(/\d/g)); // returns iterator, not array

console.log('.split()')
console.log('----------------')

/* NEED TO UPDATE
console.log(`'apples,oranges'.split(',') -> ${'apples,oranges'.split(',')}`); // ["apples", "oranges"]
'abc'.split('');                       // ["a", "b", "c"]

// .join()
['a', 'b', 'c'].join('-');             // "a-b-c"

// .toUpperCase(), .toLowerCase()
'Hello'.toLowerCase();                 // "hello"
'word'.toUpperCase();                  // "WORD"

// .charAt(), .charCodeAt()
'hello'.charAt(1);                     // "e"
'hello'.charCodeAt(0);                 // 104

// String.fromCharCode()
String.fromCharCode(65);              // "A"

// Custom: reverse a string
'abc'.split('').reverse().join('');   // "cba"

// Custom: shift first character
'hello'.slice(1);                     // "ello"  (simulate .shift())
'hello'.charAt(0);                    // "h"     (get first char)

// Custom: pop last character
'hello'.slice(0, -1);                 // "hell"  (simulate .pop())
'hello'.charAt('hello'.length - 1);   // "o"     (last char)

// Custom: remove first & last character
'hello'.slice(1, -1);                 // "ell"

// Spread string into array of characters
[...'hello'];                         // ["h", "e", "l", "l", "o"]

// Count occurrences of a char
[...'banana'].filter(c => c === 'a').length;  // 3

*/

console.log('Remove non-alphabetic chars')
console.log('-----------------------')
console.log(`'abc123!'.replace(/[^a-z]/gi, '') -> '${'abc123!'.replace(/[^a-z]/gi, '')}'`); // "abc"

console.log('Capitalize first letter')
console.log('-----------------------')
console.log(`'hello'.charAt(0).toUpperCase() -> ${'hello'.charAt(0).toUpperCase()}`)  // "H"

