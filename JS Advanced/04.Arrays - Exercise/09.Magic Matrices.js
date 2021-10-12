function magicMatrices([...arr]) {
    let magicNumber = arr[0].reduce((a, b) => a + b);
    for (let row = 0; row < arr.length; row++) {
        let currentRow = arr[0].reduce((a, b) => a + b);
        for (let col = 0; col < arr[row].length;col++) {
            let currentCol = 0;
            for (let i = 0; i < arr.length; i++) {
                currentCol += arr[col][i];                
            }   
            if ( currentCol !== magicNumber || currentRow !== magicNumber) {
               return false;
            }
        }
    }
    return true;
}
magicMatrices([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]
   );
magicMatrices([[11, 32, 45],
    [21, 0, 1],
    [21, 1, 1]]
   );
   magicMatrices([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]
   );