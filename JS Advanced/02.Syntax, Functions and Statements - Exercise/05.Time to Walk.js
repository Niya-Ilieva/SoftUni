function solve(steps, lengthSteps, speed) {

    let distance = steps * lengthSteps;
    let rest = Math.floor(distance / 500);
    let timeToWalk = distance / 1000 /speed ;
    let time = timeToWalk * 60 * 60;

    let timeInHours = Math.floor(time / 3600);
    let timeInMin = Math.floor(time / 60);
    let timeInSec = Math.round(time - (timeInMin * 60));
    timeInMin += rest;

    console.log(`${timeInHours < 10 ? timeInHours + '0' : timeInHours}:${timeInMin < 10 ? timeInMin + '0' : timeInMin}:${timeInSec < 10 ? timeInSec + '0' : timeInSec}`);
}
solve(4000, 0.60, 5)
solve(2564, 0.70, 5.5)