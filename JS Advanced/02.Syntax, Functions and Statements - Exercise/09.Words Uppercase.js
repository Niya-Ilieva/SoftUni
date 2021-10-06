function solve(input) {
    let pattern = /[\W]+/g
   
    let tokens = input.split(pattern).filter(w => w.length > 0).join(', ').toUpperCase();
    
    console.log(tokens)
}
solve('Hi, how are you?')
solve('Functions in JS can be nested, i.e. hold other functions')