function addItem() {
    const items = document.querySelector('#items');
    const input = document.querySelector('#newItemText');
    const newElement = document.createElement('li');
    
    const button = document.createElement('a');
    button.textContent = '[Delete]'
    button.href = '#';
    newElement.textContent = input.value;
    newElement.appendChild(button);
    button.addEventListener('click', removeElement)
    
    
    items.appendChild(newElement);
    
    input.value = '';

    function removeElement(ev) {
        let element = ev.target.parentNode
        element.remove();
    }
}