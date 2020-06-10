// Exercise 1
console.log('Hello World!');
// alert('Alert from Javascript');
// confirm('Are you whants to star practice?');
// open('https://www.google.com/');
let userName = prompt('Write your first name please');
let userLastName = prompt('Write your last name please');
console.log('Hello ' + userName + ' ' + userLastName);

// Exercise 2
const categories = [
  { Categorie: 'Comedy' },
  { Categorie: 'Drama' },
  { Categorie: 'Action|Comedy|Drama' },
  { Categorie: 'Action|Comedy|Horror|Musical' },
  { Categorie: 'Animation|Children' },
  { Categorie: 'Action|Adventure|Thriller|War' },
  { Categorie: 'Action|Fantasy|Sci-Fi' },
];
console.log('Platzi cuenta con cursos de:');
console.log('========================================');

categories.forEach((categ) => {
  console.log('Categoría ' + categ.Categorie);
});

let num1 = prompt('Write your first number!');
let num2 = prompt('Write your second number!');
function sum(numero1, numero2) {
  return parseFloat(numero1) + parseFloat(numero2);
}

const result = sum(num1, num2);
console.log('========================================');
console.log(result);
console.log('========================================');
console.log('Addition and Multiplication...');
let sum1 = prompt('Write your firs sum number:');
let sum2 = prompt('Write your second sum number:');
let multi = prompt('Write your third multiplication number:');

const sumMulti = (sum1, sum2, multi) => {
  let suma1 = parseFloat(sum1) + parseFloat(sum2);
  let resultMulti = suma1 * parseFloat(multi);
  return resultMulti;
};

const multiplicationResul = sumMulti(sum1, sum2, multi);

console.log('========================================');
console.log('This is the result: ' + multiplicationResul.toFixed(2));
console.log('========================================');
