function solve([...arr]) {
    let result =[];

    for (let i = 0; i < arr.length; i++) {
        let max= Math.max(...result);
        if (max > arr[i] || result.includes(arr[i])) {
            continue;
        }
        result.push(arr[i]);
    }

    return result;
}
solve([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]
    );
solve([1, 
    2, 
    3,
    4]
    );
solve([20, 
    3, 
    2, 
    15,
    6, 
    1]
    );