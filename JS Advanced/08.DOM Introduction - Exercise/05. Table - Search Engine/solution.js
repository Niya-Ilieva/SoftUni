function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      Array.from(document.querySelectorAll('tbody tr')).forEach(r => r.className = '')
      const rows = Array.from(document.querySelectorAll('tbody tr'));
      const inputText = document.querySelector('#searchField').value;
      rows.forEach(row => {
         if (row.textContent.includes(inputText)) {
            row.className = 'select'
         }
      })

      document.querySelector('#searchField').value = '';
   }
}