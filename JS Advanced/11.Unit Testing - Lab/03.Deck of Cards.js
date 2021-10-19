function printDeckOfCards(cards) {
    function createCard (suitsArr){
        let result = []
        let faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        let  suits = {
              'S':'\u2660',
              'H':'\u2665',
              'D':'\u2666',
              'C':'\u2663'   
      }
        for (let i = 0; i < suitsArr.length; i++) {
            let first = suitsArr[i].slice(0, suitsArr[i].length - 1)
            let second = suitsArr[i].slice(suitsArr[i].length - 1, suitsArr[i].length)
            if (faces.includes(first) == false || Object.keys(suits).includes(second) == false) {
                    throw new Error(`Invalid card: ${suitsArr[i]}`)
            }
            let currnetPair = first + suits[second];
            result.push(currnetPair)
            
        }
      console.log(result.join(' '));
      
    }
     createCard(cards);
  }
printDeckOfCards(['AS', '10D', 'KH', '2C'])
//printDeckOfCards(['5S', '3D', 'QD', '1C'])
  