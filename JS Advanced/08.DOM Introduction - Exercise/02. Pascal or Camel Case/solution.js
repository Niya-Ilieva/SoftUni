function solve() {
  const text = document.getElementById('text').value.toLowerCase();
  const currentCase = document.getElementById('naming-convention').value;
  const splits = text.split(' ');
  let result = [];
  if (currentCase == 'Pascal Case') {
    for (let i = 0; i < splits.length; i++) {
      result.push(splits[i][0].toUpperCase() + splits[i].slice(1, splits[i].length));
    }
    document.getElementById('result').innerHTML = result.join('');
  }
  else if (currentCase == 'Camel Case') {
    result.push(splits[0]);
    for (let i = 1; i < splits.length; i++) {
      result.push(splits[i][0].toUpperCase() + splits[i].slice(1, splits[i].length));
    }
    document.getElementById('result').innerHTML = result.join('');
  }
  else {
    document.getElementById('result').innerHTML = 'Error!';
  }
}