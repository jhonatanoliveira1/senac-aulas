var num1 = parseFloat(prompt("Digite um número:"));
var num2 = parseFloat(prompt("Digite um número:"));
var num3 = parseFloat(prompt("Digite um número:"));
var num4 = parseFloat(prompt("Digite um número:"));

function higherNumber() {
  const arr = [num1, num2, num3, num4];
  const max = Math.max(...arr);
  return console.log("O maior número é: " + max);
}

higherNumber();