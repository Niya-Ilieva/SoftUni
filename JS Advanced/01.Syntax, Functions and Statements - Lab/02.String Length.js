function solve(first, second, third) {
    let totalLength = first.length + second.length + third.length;
    let avgLength =Math.floor(totalLength / 3);

    console.log(totalLength);
    console.log(avgLength);
}
solve('chocolate', 'ice cream', 'cake')
solve('pasta', '5', '22.3')