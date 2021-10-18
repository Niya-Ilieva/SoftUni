function addItem() {
    const items = document.querySelector('#items');
    const input = document.querySelector('#newItemText').value;
    const newxtElement = document.createElement('li')
    newxtElement.textContent = input;

    items.appendChild(newxtElement)
}