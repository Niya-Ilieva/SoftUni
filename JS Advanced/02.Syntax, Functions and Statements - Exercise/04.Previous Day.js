function solve(year, month, day) {
    let currentDate = `${year}-${month}-${day}`;
    let yesterday =new Date(currentDate);
    yesterday.setDate(day - 1)

    console.log(`${yesterday.getFullYear()}-${Number(yesterday.getMonth() + 1)}-${yesterday.getDate()}`);
}
solve(2016, 9, 30)
solve(2016, 10, 1)