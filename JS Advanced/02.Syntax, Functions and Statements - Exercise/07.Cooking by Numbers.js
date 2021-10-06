function solve(num, ...cmds) {

    let commands = (cmd) => {
        switch (cmd) {
            case 'chop': num /= 2; break;
            case 'dice': num = Math.sqrt(num); break;
            case 'spice': num += 1; break;
            case 'bake': num *= 3; break;
            case 'fillet': num *= 0.8; break;
            default:
                break;
        }
        return num;
    };

    for (let index = 0; index < cmds.length; index++) {
        console.log(commands(cmds[index]));
    }
}
solve('32', 'chop', 'chop', 'chop', 'chop', 'chop')
solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet')