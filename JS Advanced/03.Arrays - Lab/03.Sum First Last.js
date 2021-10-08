function sumFirstAndLast([...nums]) {
    let first = Number(nums.shift());
    let last = Number(nums.pop());
    
    return first + last;
}
sumFirstAndLast(['20', '30', '40'])
sumFirstAndLast(['5', '10'])