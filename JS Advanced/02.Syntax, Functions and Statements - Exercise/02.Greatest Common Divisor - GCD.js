function solve(first, second) {
    let firstNum = Number(first);
    let secondNum = Number(second);

    let lowest = Math.min(firstNum, secondNum);
    let biggest = Math.max(firstNum, secondNum);
    for (let i = lowest; i > 0; i--) {
        if (biggest % i == 0 && lowest % i == 0) {
            console.log(i);
            break;
        }
    }
}
solve(15, 5)
solve(2154, 458)