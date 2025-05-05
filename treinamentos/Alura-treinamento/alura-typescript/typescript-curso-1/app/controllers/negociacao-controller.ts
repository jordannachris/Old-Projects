import { Negociacao } from "../models/negociacao.js";
import { Negociacoes } from "../models/negociacoes.js";

export class NegociacaoController {
    private inputData: HTMLInputElement;
    private inputQuantidade: HTMLInputElement;
    private inputValor: HTMLInputElement;
    private negociacoes: Negociacoes = new Negociacoes();

    constructor() {
        this.inputData = document.querySelector('#data');
        this.inputQuantidade = document.querySelector('#quantidade');
        this.inputValor = document.querySelector('#valor');
    }

    adiciona(): void {
        const negociacao = this.criaNegociacao();
        this.negociacoes.adicionaNaLista(negociacao);

        const listaDeNegociacoes = this.negociacoes.lista();
        console.log(listaDeNegociacoes);
        this.limparFormulario();
    }

    criaNegociacao(): Negociacao {
        //O "Date" precisa receber uma data no formato "aaaa,mm,dd"
        //Entretando, através do input do teclado, a data vem no formato "aaaa-mm-dd"
        //Então precisamos substituir o "-" (traço) por "," (vírgula)
        //Primeiro, precisamos encontrar os "-" (traços) da data
        //Para isso usamos uma "expressao regular" (neste caso, vamos chamá-la de "exp")
        //Então colocamos o caracter que queremos encontrar entre barras 
        //Para encontrar TODOS os traços (e não só o primeiro) usamos o "g" no final
        //o "g" significa "global"
        const exp = /-/g;
        //Agora usamos o replace para substituir todos os traços por vírgulas
        const dataFormatoCorreto = new Date(this.inputData.value.replace(exp, ','));
        const quantidadeFormatoCorreto = parseInt(this.inputQuantidade.value);
        const valorFormatoCorreto = parseFloat(this.inputValor.value);

        // const negociacaoCriada = new Negociacao(
        //     dataFormatoCorreto,
        //     quantidadeFormatoCorreto,
        //     valorFormatoCorreto
        // );
        // return negociacaoCriada;

        return new Negociacao(
            dataFormatoCorreto,
            quantidadeFormatoCorreto,
            valorFormatoCorreto
        );  
    }

    limparFormulario(): void {
        this.inputData.value = '';
        this.inputQuantidade.value = '';
        this.inputValor.value = '';

        this.inputData.focus();
    }
}