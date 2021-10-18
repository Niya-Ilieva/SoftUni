function focused() {
    const section = Array.from(document.querySelectorAll('input[type="text"]'));

    section.forEach(el => {
        el.addEventListener('focus', function(e){
            const parentDiv = e.currentTarget.parentElement;

            parentDiv.classList.add('focused')
        })
        el.addEventListener('blur', function (e) {
            const parentDiv = e.currentTarget.parentElement;

            parentDiv.classList.remove('focused')
        })
    })
    
}