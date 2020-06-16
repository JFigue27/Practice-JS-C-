console.log('Challenge 9');
let currentDate = prompt('User: Please enter some quantity days, in order return it, in hours, minutes, and seconds.');

console.log(currentDate);

const day = 24;
const hour = 60;
const munite = 60;
const second = 60;

let Hours = currentDate * day;
console.log(`This ${currentDate} days`);

console.log(`Are equal to ${Hours} hours.`);
let Minutes = currentDate * (day * hour);
console.log(`Are equal to ${Minutes} minutes.`);
let Seconds = currentDate * (day * hour * munite);
console.log(`Are equal to ${Seconds} seconds.`);
