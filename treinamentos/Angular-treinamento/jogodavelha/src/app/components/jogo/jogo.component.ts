import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-jogo',
  templateUrl: './jogo.component.html',
  styleUrls: ['./jogo.component.css']
})
export class JogoComponent implements OnInit {

  quadrados: any[] = [];
  xEhProx: boolean = false;
  vencedor: any;
  conta_click: number = 0;

  constructor() { }

  ngOnInit(): void {
    this.novoJogo();
  }

  novoJogo() {
    this.quadrados = Array(9).fill(null);
    this.vencedor = null;
    this.xEhProx = true;
    this.conta_click = 0;
  }

  get jogador() {
    return this.xEhProx ? 'X' : 'O';
  }

  fazerJogada(indice: number) {
    if (!this.quadrados[indice]) {
      this.quadrados.splice(indice, 1, this.jogador);
      this.xEhProx = !this.xEhProx;
    }
    this.vencedor = this.calcularVencedor();
    this.conta_click++;
  }

  calcularVencedor() {
    const jogadasVencedoras = [
      [0, 1, 2],
      [3, 4, 5],
      [6, 7, 8],
      [0, 3, 6],
      [1, 4, 7],
      [2, 5, 8],
      [0, 4, 8],
      [2, 4, 6]
    ];

    for (let i = 0; i < jogadasVencedoras.length; i++) {
      const [a, b, c] = jogadasVencedoras[i];
      if (this.quadrados[a] &&
        this.quadrados[a] === this.quadrados[b] &&
        this.quadrados[a] === this.quadrados[c]
      ){
        return this.quadrados[a];
      }
    }
    return null;
  }
}
