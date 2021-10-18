function attachGradientEvents() {
    const gradient = document.getElementById('gradient');
    gradient.addEventListener('mousemove', mouseMove);
    let percentOutput = document.getElementById('result');

    function mouseMove(ev) {
        let box = ev.target;
        let offset = Math.floor(ev.offsetX / box.clientWidth * 100)

        percentOutput.textContent = `${offset}%`;
    }
}