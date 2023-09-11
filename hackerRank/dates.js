function getDayName(dateString) {
    let dayName;
    // Write your code here
    let days = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
    let date = new Date(dateString);
    dayName = days[date.getDay()]
    console.log(dayName);
    
    return dayName;
}
getDayName("10/11/2009");