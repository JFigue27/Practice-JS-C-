console.log('Challenge 1');
let num1 = prompt('Enter the first number...');
let num2 = prompt('Enter the second number...');

if (parseInt(num1) > parseInt(num2)) {
  debugger;
  console.log(`This is the mayor number ${num1}`);
  let diference = num1 - num2;
  console.log('This is the diference ' + diference + ' between: ' + num1 + ' and ' + num2);
} else {
  console.log(`This is the mayor number ${num2}`);
  let diference = num2 - num1;
  console.log('This is the diference ' + diference + ' between: ' + num2 + ' and ' + num1);
}
