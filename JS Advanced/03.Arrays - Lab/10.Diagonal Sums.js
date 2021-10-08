function diagonalSum([...arr]) {
    let firstDiagonal = 0;
    let secondDiagonal = 0;
    let firstIndex = 0;
    let secondIndex = arr[0].length - 1;

    arr.forEach(el => {
        firstDiagonal += el[firstIndex++];
        secondDiagonal += el[secondIndex--];
    });

    console.log(`${firstDiagonal} ${secondDiagonal}`);    
}
diagonalSum([[20, 40],
    [10, 60]] );
diagonalSum([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]);