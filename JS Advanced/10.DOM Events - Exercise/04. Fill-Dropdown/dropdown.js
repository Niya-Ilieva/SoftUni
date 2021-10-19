function addItem() {
    const textInput = document.getElementById('newItemText');
    const valueInput = document.getElementById('newItemValue');
    const menu = document.getElementById('menu');
    const divElement = document.createElement('option');
    divElement.textContent = `${textInput.value} ${valueInput.value}`;
    menu.appendChild(divElement)
    textInput.value = '';
    valueInput.value = '';
}