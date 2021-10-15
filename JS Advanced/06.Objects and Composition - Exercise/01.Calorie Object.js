function calories(arr) {
    let result = {};
    for (let i = 0; i < arr.length; i+= 2) {
        let currentName = arr[i];
        let currentCalories = Number(arr[i + 1]); 
        result[currentName] = currentCalories;
    }
    console.log(result);
}

calories(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
calories(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);