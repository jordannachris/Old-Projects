export class Conta {

    constructor(saldoInicial, cliente, agencia){
        //O underline na frente serve para mostrar que é um atributo PRIVADO
        this._saldo = saldoInicial;
        this._cliente = cliente;
        this._agencia = agencia;
    }


    set cliente(novoValor){
        if(novoValor instanceof Cliente){
            this._cliente = novoValor;
        }
    }
    
    get cliente(){
        return this._cliente;
    }

    get saldo(){
        return this._saldo;
    }


    sacar(valor) {
        let taxa = 1;

        if(this._tipo == "corrente"){
            taxa = 1.1;
        }

        const valorSacado = taxa * valor;

        if (this._saldo >= valorSacado) {
            this._saldo = this._saldo - valorSacado;
            return valorSacado;
        }
    }

    depositar(valor) {
        if (valor <= 0) {
            return;
        }
        this._saldo += valor;
        // if(valor > 0){
        //     this.__saldo = this.__saldo + valor;
        // }
    }

    transferir(valor, conta){
        const valorSacado = this.sacar(valor);
        conta.depositar(valorSacado);
    }

    teste(){
        console.log("teste na classe conta corrente");
    }
}