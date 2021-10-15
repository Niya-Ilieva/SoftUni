function factory(obj) {
    let result = {
        model: obj.model,
        engine: getEngine(obj.power),
        carriage: {
            type: obj.carriage,
            color: obj.color
        },
        wheels: getWheels(obj.wheelsize)
    }
    
    function getEngine(power) {
        if (power <= 90) {
            return {power: 90, volume: 1800};
        }
        else if (power <= 120){
            return {power: 120, volume: 2400};
        }
        else if (power <= 200){
            return {power: 200, volume: 3500};
        }
    }
    function getWheels(size) {
        let wheelSize = []
        if (size % 2 == 0) {
            size -= 1
        }
        for (let index = 0; index < 4; index++) {
            wheelSize.push(size);
        }
        return wheelSize;
    }

    return result;
}
factory({ model: 'VW Golf II',
power: 90,
color: 'blue',
carriage: 'hatchback',
wheelsize: 14 }
);
factory({ model: 'Opel Vectra',
power: 110,
color: 'grey',
carriage: 'coupe',
wheelsize: 17 }
);