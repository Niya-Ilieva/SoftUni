function toggle() {
    const button = document.querySelector('span');
    const text = document.querySelector('#extra p').innerHTML

    if (button.textContent == 'More') {
        document.querySelector('#extra').style.display = 'block';
        button.innerHTML = 'Less'
    }
    else if (button.textContent == 'Less'){
        document.querySelector('#extra').style.display = 'none';
        button.innerHTML = 'More'
    }
}