export class Negociacao {
    private _data: Date;
    private _quantidade: number;
    private _valor: number;

    constructor(data: Date, quantidade: number, valor: number) {
        this._data = data;
        this._quantidade = quantidade;
        this._valor = valor;
    }

    //Outra maneira de fazer:
    //Dá para apagar o conteúdo das linhas 2 à 10 
    //E substituir pelo conteúdo das linhas 15 à 19
    // constructor (
    //     private _data: Date,
    //     private _quantidade: number,
    //     private _valor: number
    // ) {}

    get data(): Date {
        return this._data;
    } 

    //Outra maneira de fazer o "get data()" 
    //Serve para impedir que alguém altere o valor de _data através de um setDate
    // get data(): Date {
    //     const data = new Date(this._data.getTime()); //cria uma cópia de this._data
    //     return data; //retorna a cópia, o que impede que outra pessoa altere o valor "original" de _data
    // }

    get quantidade(): number {
        return this._quantidade;
    }

    get valor(): number {
        return this._valor;
    }

    get volume(): number {
        return this._quantidade * this._valor;
    }
}