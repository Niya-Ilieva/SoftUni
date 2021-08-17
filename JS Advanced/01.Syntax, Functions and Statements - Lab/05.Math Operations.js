function solve(first, second, operator) {
    let firstNum = Number(first);
    let secondNum = Number(second);
    let result;

    if (operator === '+') {
        result = firstNum + secondNum;
    }
    else if (operator === '-') {
        result = firstNum - secondNum;
    }
    else if (operator === '*') {
        result = firstNum * secondNum;
    }
    else if (operator === '/') {
        result = firstNum / secondNum;
    }
    else if (operator === '%') {
        result = firstNum % secondNum;
    }
    else if (operator === '**') {
        result = firstNum ** secondNum;
    }

    console.log(result);
}
solve(5, 6, '+')
solve(3, 5.5, '*')