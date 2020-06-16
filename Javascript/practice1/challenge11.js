console.log('Challenge 11');

const GreaterThan = prompt('Entrer a number greater than 1000');
const SmallerThan = prompt('Entrer a number smaller than 100');

const dividedBy = GreaterThan / SmallerThan;

console.log(`This is the result ${parseFloat(dividedBy).toFixed(2)}`);
