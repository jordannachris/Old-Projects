import { Component, OnInit } from '@angular/core';
import { ImoveisApiModel } from 'src/app/services/imoveis-api-model';
import { ImoveisApiService } from 'src/app/services/imoveis-api.service';

@Component({
  selector: 'app-imoveis-slide-show',
  templateUrl: './imoveis-slide-show.component.html',
  styleUrls: ['./imoveis-slide-show.component.css']
})
export class ImoveisSlideShowComponent implements OnInit {
  private listaDeImoveis: ImoveisApiModel[] = [];
  private indiceAtual = 0;
  exibirImagem = false;
  imagemAtual = '';

  constructor(public imoveisApi: ImoveisApiService) { }

  ngOnInit(): void {
    this.imoveisApi.get().subscribe({
      next: (retorno) => this.inicializar(retorno)
    });
  }

  private inicializar(dadosApi: ImoveisApiModel[]): void {
    this.listaDeImoveis = dadosApi;
    this.definirImagem();
  }

  private definirImagem(): void {
    this.imagemAtual = this.listaDeImoveis[this.indiceAtual].image;
    this.exibirImagem = true;
  }

  public anterior(): void {
    if (this.indiceAtual === 0) {
      this.indiceAtual = this.listaDeImoveis.length - 1;
    }
    else {
      this.indiceAtual--;
    }
    this.definirImagem();
  }

  public proximo(): void {
    if (this.indiceAtual === this.listaDeImoveis.length - 1) {
      this.indiceAtual = 0;
    }
    else {
      this.indiceAtual++;
    }
    this.definirImagem();
  }
}
