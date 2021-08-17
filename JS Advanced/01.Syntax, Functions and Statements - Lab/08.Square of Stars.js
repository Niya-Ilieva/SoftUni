function solve(size) {
    let staticSize = 5;
    if (size == undefined) {
        size = staticSize;
    }
    for (let i = 0; i < size; i++) {
        let output = '';
        for (let j = 0; j < size; j++) {
            output += '* '
        }
        console.log(output.trim());
    }

}
solve(1);
solve(2);
solve(5);
solve();