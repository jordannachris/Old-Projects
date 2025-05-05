console.log(`Trabalhando com listas`);

// const salvador = `Salvador`;
// const saoPaulo = `São Paulo`;
// const rioDeJaneiro = `Rio de Janeiro`;

console.log("Destinos possíveis: ");
// console.log (salvador, saoPaulo, rioDeJaneiro);

const listaDeDestinos = new Array(
    `Salvador`,
    `São Paulo`,
    `Rio de Janeiro`
);

listaDeDestinos.push(`Curitiba`);

console.log(listaDeDestinos);

listaDeDestinos.splice(1,1); //começa a excluir na posição 1, e exclui um total de 1 elemto

console.log(listaDeDestinos);

listaDeDestinos.push(`Goiania`);
listaDeDestinos.push(`Palmas`);

console.log(listaDeDestinos);

listaDeDestinos.splice(0,2); //começa a excluir na posição 0, e exclui um total de 2 elemtos

console.log(listaDeDestinos);

console.log(listaDeDestinos[1], listaDeDestinos[0]);