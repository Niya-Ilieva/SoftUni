function rotateArray([...arr], number) {
    for (let index = 0; index < number; index++) {
        let current = arr.pop();
        arr.unshift(current);
    }

    console.log(arr.join(' '));
}
rotateArray(['1', 
'2', 
'3', 
'4'], 
2
);
rotateArray(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
)