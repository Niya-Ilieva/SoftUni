function oddPositions([...numbers]) {
    let result = numbers.filter((el, index) => index % 2 !== 0).map(x => x * 2).reverse();

    return result;
}
oddPositions([10, 15, 20, 25]);
oddPositions([3, 0, 10, 4, 7, 3]);