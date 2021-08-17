function solve(first, second, third) {
    let firstNumber = Number(first);
    let secondNumber = Number(second);
    let thirdNumber = Number(third);

    let largest = Math.max(first, second, third);

    console.log(`The largest number is ${largest}.`);
}
solve(5, -3, 16)
solve(-3, -5, -22.5)