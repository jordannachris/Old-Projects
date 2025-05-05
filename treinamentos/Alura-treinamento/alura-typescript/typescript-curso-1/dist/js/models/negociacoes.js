export class Negociacoes {
    constructor() {
        this.listaNegociacoes = [];
        //Outra maneira de escrever o código das linhas 13 à 15:
        // lista(): readonly Negociacao[] {
        //     return this.listaNegociacoes;
        // }
    }
    //Outra maneira de escrever o código da linha 4:
    //private listaNegociacoes: Negociacao[] = [];
    adicionaNaLista(negociacao) {
        this.listaNegociacoes.push(negociacao);
    }
    lista() {
        return this.listaNegociacoes;
    }
}
