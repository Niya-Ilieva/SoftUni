function solve(speed, area) {
    let speedlimit;
    let speeding = (speed, speedlimit) => {
        let difference = speed - speedlimit;
        
        if (difference <= 20) {
            return 'speeding';
        }
        else if (difference <= 40) {
            return 'excessive speeding';
        }
        return 'reckless driving';
    }
    switch (area) {
        case 'motorway': speedlimit = 130; break;
        case 'interstate': speedlimit = 90; break;
        case 'city': speedlimit = 50; break;
        case 'residential': speedlimit = 20; break;
        default:
            break;
    }

    if (speed <= speedlimit) {
        console.log(`Driving ${speed} km/h in a ${speedlimit} zone`);
    }
    else{
        let difference = speed - speedlimit;
        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedlimit} - ${speeding(speed, speedlimit)}`);
    }
}
solve(40, 'city');
solve(21, 'residential');
solve(120, 'interstate');
solve(200, 'motorway');