function addAndRemoveElements([...arr]) {
    let result = [];
    for (let i = 0; i < arr.length; i++) {
        let cmd = arr[i];
        switch (cmd) {
            case 'add': result.push(i + 1); break;
            case 'remove': result.pop(); break;
            default:
                break;
        }
    }
    if (result.length <= 0) {
        console.log('Empty');
    }
    else {
        result.forEach(e => console.log(e))
    }
}
addAndRemoveElements(['add', 
'add', 
'add', 
'add']
);
addAndRemoveElements(['add', 
'add', 
'remove', 
'add', 
'add']
);
addAndRemoveElements(['remove', 
'remove', 
'remove']
);