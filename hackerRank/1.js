let date = new Date("2023-09-12");
let days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"]
let day = days[date.getDay()];
console.log("days:-",days)

console.log(date.toString())
console.log(date.toDateString())
console.log(date.toUTCString())
console.log(date.toISOString())
console.log(date.getDay())