function sortingNumbers([...arr]) {
    let sorted = arr.sort((a, b) => a - b);
    let arrLength = sorted.length;
    let result = []
    for (let i = 0; i < arrLength; i++) {
        if (i % 2 == 0) {
            result.push(sorted.shift());
        }
        else {
            result.push(sorted.pop());
        }
    }
    return result;
}
sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);
