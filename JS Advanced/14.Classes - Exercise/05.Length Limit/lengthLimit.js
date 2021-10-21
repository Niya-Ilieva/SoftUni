class Stringer{
    constructor(innerString, innerLength){
        this.innerString = innerString;
        this.innerLength = innerLength;
    }

    increase(length){
        this.innerLength += length;
    }

    decrease(length){
        if (this.innerLength - length < 0 ) {
            this.innerLength = 0;
        }
        else{
            this.innerLength -= length;
        }
    }
    toString(){
        if (this.innerString.length <= this.innerLength) {
            return this.innerString
        }
        return `${this.innerLength == 0 ?'...': this.innerString.substr(0 , this.innerLength) + '...' }`
    }
}
let test = new Stringer("Test", 5);
console.log(test.toString()); // Test

test.decrease(3);
console.log(test.toString()); // Te...

test.decrease(5);
console.log(test.toString()); // ...

test.increase(4); 
console.log(test.toString()); 
