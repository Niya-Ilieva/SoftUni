function attachEventsListeners() {
    const ratios = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    }
    const buttons = document.querySelectorAll('input[type="button"]');
    for (const btn of buttons) {
        btn.addEventListener('click', function(e) {
            const input = e.target.parentElement.querySelector('input[type="text"]');
            const converted = convert(Number(input.value), input.id)
            inputDays.value = converted.days;
            inputHours.value = converted.hours;
            inputMinutes.value = converted.minutes;
            inputSeconds.value = converted.seconds;
        })
    }

    function convert(value, unit) {
        const days = value / ratios[unit];
        return {
            days: days,
            hours: days * ratios.hours,
            minutes: days * ratios.minutes,
            seconds: days * ratios.seconds
        }
    }
    const inputDays = document.querySelector('#days');
    const inputHours = document.querySelector('#hours');
    const inputMinutes = document.querySelector('#minutes');
    const inputSeconds = document.querySelector('#seconds');
}
