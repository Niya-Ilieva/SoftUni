function solve(arr) {
    let sum = arr.reduce((a, b) => a + b);
    let sum2 = arr.map( x => 1 / x).reduce((a, b) => a + b);
    let concat = arr.join('');

    console.log(sum);
    console.log(sum2);
    console.log(concat);
}
solve([1, 2, 3]);
solve([2, 4, 8, 16]);