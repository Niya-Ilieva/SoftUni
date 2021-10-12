function printNthElement([...arr], step) {
    let result = arr.filter((n, i) => i % step == 0);

    return result;
}
printNthElement(['5', 
'20', 
'31', 
'4', 
'20'], 
2
);
printNthElement(['dsa',
'asd', 
'test', 
'tset'], 
2
);
printNthElement(['1', 
'2',
'3', 
'4', 
'5'], 
6
);