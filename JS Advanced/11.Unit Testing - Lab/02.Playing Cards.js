function cards(face, suit) {
    let faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
      let  suits = {
            'S':'\u2660',
            'H':'\u2665',
            'D':'\u2666',
            'C':'\u2663'   
    }
    if (faces.includes(face) == false || Object.keys(suits).includes(suit) == false) {
            throw new Error('Error')
    }
    return {
        face,
        suit: suits[suit],
        toString() {
            return this.face + this.suit
        }
    }
}
console.log(cards('V', 'S').toString());