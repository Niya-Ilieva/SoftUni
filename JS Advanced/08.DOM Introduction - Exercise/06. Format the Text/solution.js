function solve() {
  const inputText = document.getElementById('input').value;
  const output = document.getElementById('output')
  const splitText = inputText.split('.').filter(e => e != "");


  let count = 0;
  let lengthCount = 0;
  let result = [];
  splitText.forEach(sentence => {
    result.push(`${sentence}.`);
    count++;
    lengthCount++;
    if (count == 3 || lengthCount == splitText.length) {
      output.innerHTML += `<p>${result.join('')}</p>`;
      result = [];
      count = 0;
    } 
  });
}