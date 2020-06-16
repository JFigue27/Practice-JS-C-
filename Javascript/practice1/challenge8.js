console.log('Challenge 8');
let bill = prompt('Waiter, the bill please.');
console.log('Bill:' + parseFloat(bill));
let persons = prompt('How many are we are?');
console.log(persons + ' Persons.');
let tipPercent = prompt("Guys, what's the percent for the tip?");
console.log('Tip % ' + tipPercent);

const taxesPercent = 0.16;

const Total = (b, t, taxes) => {
  let Tip = parseFloat(b) * parseFloat(t);
  console.log('Tip $' + Tip);

  let TotalTaxes = parseFloat(b) * parseFloat(taxes);
  console.log('Taxes % ' + taxesPercent);
  console.log('Taxes $ ' + TotalTaxes);

  let Total = parseFloat(b) + parseFloat(Tip) + parseFloat(TotalTaxes);
  return Total;
};

const total = Total(bill, tipPercent, taxesPercent);
console.log('Account Total, included tip and taxes: $' + total.toFixed(2));

const dividedByPerson = (persons, total) => {
  let TotalByPerson = total / persons;
  return TotalByPerson;
};

const totalByPerson = dividedByPerson(persons, total);
console.log('Account total by person, included tip and taxes: $' + totalByPerson.toFixed(2));
