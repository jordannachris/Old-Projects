import { Negociacao } from "./negociacao.js";

export class Negociacoes {
    private listaNegociacoes: Array<Negociacao> = [];
    //Outra maneira de escrever o código da linha 4:
    //private listaNegociacoes: Negociacao[] = [];


    adicionaNaLista(negociacao: Negociacao) {
        this.listaNegociacoes.push(negociacao);
    }

    lista(): ReadonlyArray<Negociacao> {
        return this.listaNegociacoes;
    }
    //Outra maneira de escrever o código das linhas 13 à 15:
    // lista(): readonly Negociacao[] {
    //     return this.listaNegociacoes;
    // }
}
