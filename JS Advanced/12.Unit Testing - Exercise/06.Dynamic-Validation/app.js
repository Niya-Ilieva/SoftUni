function validate() {
    const emailInput = document.querySelector('#email');
    emailInput.addEventListener('change', function (e) {
        const pattern = /^[a-z]+@[a-z]+\.[a-z]+$/

        if (pattern.test(e.target.value)) {
            e.target.classList.remove('error')
        }
        else{
            e.target.classList.add('error')
        }
    });
}