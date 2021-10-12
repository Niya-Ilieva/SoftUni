function printArrayWithDelimiter([...arr], delimiter) {
    let result = arr.join(delimiter);

    console.log(result);
}
printArrayWithDelimiter(['One', 
'Two', 
'Three', 
'Four', 
'Five'], 
'-'
);
printArrayWithDelimiter(['How about no?', 
'I',
'will', 
'not', 
'do', 
'it!'], 
'_'
);