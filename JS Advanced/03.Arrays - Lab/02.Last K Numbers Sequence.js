function lastKNumbers(n, k) {
    let res = [];
    res[0] = 1
     for (let i = 1; i < n; i++) {
         if (res.length < k) {
             let short = res.reduce((a, b) => a + b);
             res[i] = Number(short);
             continue;
         }
      let startPosition = res.length - k;
      let endPosition = i;
      let current = res.slice(startPosition, endPosition);
    
      let sum = current.reduce((a, b) => a + b);
      res[i] = Number(sum);
     
   }
   //console.log(res);
    return res;
}
lastKNumbers(6, 3)