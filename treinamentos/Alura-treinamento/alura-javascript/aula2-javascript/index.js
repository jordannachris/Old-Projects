import { Cliente } from "./Cliente.js";
import { ContaCorrente } from "./ContaCorrente.js";
import { ContaPoupanca } from "./ContaPoupanca.js";
import { Conta } from "./Conta.js";

const cliente1 = new Cliente("Ricardo", 11122233309);
// cliente1.nome = "Ricardo";
// cliente1.cpf = 11122233309;

const cliente2 = new Cliente("Alice", 88822233309);
// cliente2.nome = "Alice";
// cliente2.cpf = 88822233309;


const contaCorrente = new ContaCorrente(cliente1, 1001);

contaCorrente.depositar(500);
contaCorrente.sacar(100);

const contaPoupanca = new ContaPoupanca(50, cliente2, 1002);

console.log(contaCorrente);
console.log(contaPoupanca);
