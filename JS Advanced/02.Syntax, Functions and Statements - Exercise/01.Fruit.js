function solve(fruit, weight, money) {
    let weightInKg = Number(weight) / 1000;
    let moneyNeeded = weightInKg * Number(money);

    console.log(`I need $${moneyNeeded.toFixed(2)} to buy ${weightInKg.toFixed(2)} kilograms ${fruit}.`);
}
solve('orange', 2500, 1.80);
solve('apple', 1563, 2.35);