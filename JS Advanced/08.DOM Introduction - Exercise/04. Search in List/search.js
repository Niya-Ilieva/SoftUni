function search() {
   let towns = Array.from(document.querySelectorAll('#towns li'));
   let text = document.querySelector('#searchText').value;
   let matches = 0;
   towns.forEach(town => {

      if (town.textContent.includes(text)) {
         matches ++;
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
      }
   })
   document.querySelector('#result').innerHTML = `${matches} matches found`
   document.querySelector('#searchText').value = '';
}
