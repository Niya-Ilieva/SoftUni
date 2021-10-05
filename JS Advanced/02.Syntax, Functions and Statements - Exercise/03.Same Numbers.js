function solve(input) {
    let InputAsString = input.toString();
    let sum = InputAsString.split('').map(Number).reduce((a, c) => a + c);
    let areSame = true;
    for (let i = 0; i < InputAsString.length - 1; i++) {
        if (InputAsString[i] != InputAsString[i + 1]) {
            areSame = false;
            break;
        }
    }
    console.log(areSame);
    console.log(sum);
}
solve(2222222);
solve(1234)