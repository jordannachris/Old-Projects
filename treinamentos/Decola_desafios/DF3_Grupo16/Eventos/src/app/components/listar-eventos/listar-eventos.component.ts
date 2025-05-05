import { Component, OnInit } from '@angular/core';
import { ListarEventosApiModel } from 'src/app/services/listar-eventos-api-model';
import { ListarEventoService } from 'src/app/services/listar-evento.service';


@Component({
  selector: 'app-listar-eventos',
  templateUrl: './listar-eventos.component.html',
  styleUrls: ['./listar-eventos.component.css']
})

export class ListarEventosComponent implements OnInit {

  mostrarLista: boolean = false;
  idCategoriaEvento: number = 0;
  //dataEvento = new Date();
  dataEvento: string = '';
  listaDeEventos: ListarEventosApiModel[] = [];
  listaDeEventosCategoria: ListarEventosApiModel[] = [];
  listaDeEventosData: ListarEventosApiModel[] = [];

  constructor(public listareventosApi:ListarEventoService) { }


  ngOnInit(): void {
    this.listareventosApi.getListaEventos().subscribe({
      next: (retornoDaApi) => {
        this.listaDeEventos = retornoDaApi;
      }
    });
  }

  clickMostrarListaCategoria() {
    this.listareventosApi.getListaEventosByCategoria(this.idCategoriaEvento).subscribe({
      next: (retornoDaApi) => {
        this.listaDeEventosCategoria = retornoDaApi;
      }
    });
    this.mostrarLista = true;
  }

  clickMostrarListaData() {
    let dataFormatada = this.dataFormatadaParaFiltro(new Date(this.dataEvento));
    this.listareventosApi.getListaEventosByData(dataFormatada).subscribe({
      next: (retornoDaApi) => {
        this.listaDeEventosData = retornoDaApi;
      }
    });
    this.mostrarLista = true;
  }

  dataFormatadaParaFiltro(data: Date){
    let dia  = data.getDate().toString();
    let mes  = (data.getMonth()+1).toString();
    let ano = data.getFullYear();
    return ano+"-"+mes+"-"+dia;
}


}

