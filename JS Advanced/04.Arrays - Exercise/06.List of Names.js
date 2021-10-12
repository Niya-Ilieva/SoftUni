function listOfNames(arr) {
    let count = 1;
    let result = arr.sort((a, b) => a.localeCompare(b)).forEach(el => console.log(`${count++}.${el}`));

}
listOfNames(["John", "Bob", "Christina", "Ema"]);
