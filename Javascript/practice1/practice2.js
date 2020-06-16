console.log('Test practice 2');
console.log('Reto 6 - "Resta de pezzas"');

let Xslices = prompt('Please tell me how many slices of pizza do we have?');
console.log('X :' + Xslices);

let Yslices = prompt('After some time ago, how many pizzas do we have?');
console.log('Y :' + Yslices);

const restaPizzas = (X, Y) => {
  let Z = parseFloat(Xslices) - parseFloat(Yslices);
  return Z;
};

const zzz = restaPizzas(Xslices, Yslices);
console.log('This is the result :' + zzz);
