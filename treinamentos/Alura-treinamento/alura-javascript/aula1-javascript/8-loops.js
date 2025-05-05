console.log(`Trabalhando com condicionais`);

const listaDeDestinos = new Array(
    `Salvador`,
    `São Paulo`,
    `Rio de Janeiro`,
    `Curitiba`
);

const idadeComprador = 15;
let maiorDeIdade = false;
const estaAcompanhado = false;
// let temPassagemComprada = false;
const destino = "Curitiba";

if (idadeComprador >= 18) {
    maiorDeIdade = true;
}
console.log("Destinos possíveis: ");
console.log(listaDeDestinos);

const podeComprar = (maiorDeIdade == true) || (estaAcompanhado == true);
let contador = 0;
let destinoExiste = false;

// while (contador < listaDeDestinos.length){ 
//     if(destino == listaDeDestinos[contador]){
//         console.log("Destino existe!");
//         destinoExiste = true;
//         break;
//     }
//     contador += 1;
// }

for (contador = 0; contador < listaDeDestinos.length; contador++){ 
    if(destino == listaDeDestinos[contador]){
        console.log("Destino existe!");
        destinoExiste = true;
        break;
    }
}

if(podeComprar && destinoExiste){
    console.log("Boa viagem!");
}
else{
    console.log("Desculpe, tivemos um erro.");
}