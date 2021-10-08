function solve([...nums]) {
    let result = [];
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] < 0) {
            result.unshift(nums[i]);
        }
        else {
            result.push(nums[i]);
        }
    }
     nums.sort(function(a, b) {return a - b});

     for (const num of result) {
        console.log(num);   
     }
}
solve([7, -2, 8, 9]);
solve([3, -2, 0, -1]);