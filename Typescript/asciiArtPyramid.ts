let N = 10;

for(let i = 0; i < N; i++) {
    let emptySpaces = N - i - 1;
    let stars = 2 * i + 1;
    let outString = `${' '.repeat(emptySpaces)}${'*'.repeat(stars)}`;
    
    console.log(`${outString}`);
}