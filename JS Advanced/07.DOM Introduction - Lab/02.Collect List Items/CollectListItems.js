function extractText() {
    const items = document.querySelectorAll('#items');
    const textArea = document.querySelector('#result');
    for (const item of items) {
        textArea.value += item.textContent
    }
}