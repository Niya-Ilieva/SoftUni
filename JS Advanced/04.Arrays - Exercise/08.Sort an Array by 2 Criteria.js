function sortArray([...arr]) {
    let sorted = arr.sort((a, b) => {
        if (a.length > b.length) {
            return 1;
        }
        else if(a.length == b.length){
            return a.localeCompare(b);
        }
        else {
            return -1;
        }
    });

    sorted.forEach(e => {
        console.log(e);
    });
}
sortArray(['alpha', 
'beta', 
'gamma']
);
sortArray(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']
);
sortArray(['test', 
'Deny', 
'omen', 
'Default']
);