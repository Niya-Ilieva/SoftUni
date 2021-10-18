function deleteByEmail() {
    const input = document.querySelector('input[name="email"]').value;
    const tableRows = document.querySelectorAll('#customers tr td:nth-child(2)')
    for (const row of tableRows) {
        if (row.textContent == input) {
            let currentRow = row.parentNode;
            currentRow.parentNode.removeChild(currentRow)
            document.querySelector('#result').textContent = 'Deleted.';
            return;
         }
         document.querySelector('#result').textContent = 'Not found.'   
    }
}