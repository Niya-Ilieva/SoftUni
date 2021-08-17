function solve(first, second) {
    let firstNum = Number(first);
    let secondNum = Number(second);
    let result = 0;
    for (let i = firstNum; i <= secondNum; i++) {
        result += i;
    }
    return result;
}
solve('1', '5')
solve('-8', '20')