function biggerHalf([...arr]) {
    let startPoint = Math.floor(arr.length / 2);
    let sorted = arr.sort((a, b) => a - b).slice(startPoint, arr.length);

    return sorted;
}
biggerHalf([4, 7, 2, 5]);
biggerHalf([3, 19, 14, 7, 2, 19, 6])