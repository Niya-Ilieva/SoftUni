function townPopulation(arr) {
    let towns = {};
    for (let i = 0; i < arr.length; i++) {
        let current = arr[i].split(' <-> ');
        townName = current[0];
        population = Number(current[1]);
        if (towns[townName] != undefined) {
            towns[townName] += population
        }
        else {
            towns[townName] = population
        }
    }

    for (const town in towns) {
        console.log(`${town} : ${towns[town]}`);
    }
}
townPopulation(['Sofia <-> 1200000',
'Montana <-> 20000',
'New York <-> 10000000',
'Washington <-> 2345000',
'Las Vegas <-> 1000000']
);
townPopulation(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']
);