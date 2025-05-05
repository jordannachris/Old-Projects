console.log(`Trabalhando com condicionais`);

const listaDeDestinos = new Array(
    `Salvador`,
    `São Paulo`,
    `Rio de Janeiro`,
    `Curitiba`
);

const idadeComprador = 20;
let maiorDeIdade = false;
const estaAcompanhado = true;
const temPassagemComprada = true;

if (idadeComprador >= 18) {
    maiorDeIdade = true;
}
console.log("Destinos possíveis: ");
console.log(listaDeDestinos);

// if (maiorDeIdade) {
//     console.log("\nComprador maior de idade: ");
//     listaDeDestinos.splice(0, 1); //remove primeiro item da lista, pq "vendeu" o primeiro item
// }
// else if (estaAcompanhado) {
//     console.log("\nComprador menor de idade MAS está acompanhado.");
//     listaDeDestinos.splice(0, 1);
// }
// else {
//     console.log("\nComprador menor de idade e NÃO está acompanhado. ");
// }
// console.log(listaDeDestinos);

// console.log(idadeComprador >= 18);
// console.log(idadeComprador <= 18);

if(maiorDeIdade || estaAcompanhado){
    console.log("\nComprador atende as condições.");
    listaDeDestinos.splice(0, 1);
}
else{
    console.log("\nComprador NÃO atende as condições.. ");
}
console.log(listaDeDestinos);

console.log("\nEmbarque:");

if(maiorDeIdade && temPassagemComprada){
    console.log("Boa viagem!");
}
else {
    console.log("Você não pode embarcar.\n");
}