const greet = (name: string) : string => {
  return `Hello ${name}!`;
}

console.log(greet('Gman'));

class myObj {
  name: string
  type: string
  description: string
}

let myArr = ['hey','allo','bonjour','hola']

let obj1 = new myObj();

console.log('Javascript map usage example:')
console.log(myArr.map((el, i) => `${i}.${el}`))

console.log('Javascript filter usage example:')
console.log(myArr.filter(el => el.length > 3))

console.log('Javascript reduce usage example:')
console.log(myArr.reduce((acc, el) => acc + el.length, 0))

function delay(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}
const promises: Promise<void>[] = [];

console.log('Javascript closure and IIFE example:')
for(var i = 0; i < 4; i++){
  const promise = (async function(j: number){
    await delay(500)
    console.log(j)
    // setTimeout(() => {
    //   console.log(j)
    // }, 500)
  })(i)

  promises.push(promise);
}

Promise.all(promises).then(() => {
  console.log('Typescript Basic Types');
  console.log('number -> let amount: number = 5')
  let amount: number = 5
  console.log(`amount: ${amount}`)

  console.log('boolean -> let isReady: boolean = true')
  let isReady: boolean = true
  console.log(`isReady: ${isReady}`)

  console.log(`string -> let description: string = 'this is how you learn Typescript!'`)
  let description: string = 'this is how you learn Typescript!'
  console.log(`description: ${description}`)

  console.log('enum -> ')
  enum Direction {
    Up,
    Down,
    Left,
    Right,
  }
  let move: Direction = Direction.Up;

  console.log(`opt out of type checking with 'any' keyword`);
  let something: any = "hello";
  something = 5;
})

console.log(`Javascript 'let' keyword is Block-Scoped, 'var' keyword' is Function-Scoped`);

console.log('Wiring html button to Typescript/Javascript code via property binding: ');
console.log(`<button id="myButton" onClick="clickHandler()">`);
console.log('Wiring html button to Typescript/Javascript code via explicit event listener:');
console.log(`document.addEventListener('DOMContentLoaded', () => {
    var button = document.getElementById('myButton');
    
    if (button) {
        button.addEventListener('click', clickHandler);
    }
});`);




//async/await, promises, ES6+

//TypeScript: types, interfaces, generics, utility types (Partial, Pick, Record, etc.)

//TypeScript Focus
// Generics

// Type narrowing & guards

// Advanced utility types

// Mapped & conditional types