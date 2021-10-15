function heroes(arr) {
    let heroes = [];
    for (let i = 0; i < arr.length; i++) {
        let[name, level, itemsArr] = arr[i].split(' / ');
        level = Number(level);
        let items = itemsArr ?  itemsArr.split(', '): [];
        let currentHero = {
            name,
            level,
            items
        }
        heroes.push(currentHero);
        
    }
    let result = JSON.stringify(heroes);
    console.log(result);
}
heroes(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
);
heroes(['Jake / 1000 / Gauss, HolidayGrenade']);