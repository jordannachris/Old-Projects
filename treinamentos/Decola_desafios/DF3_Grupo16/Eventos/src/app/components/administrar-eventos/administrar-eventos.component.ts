import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdministraEventoService } from 'src/app/services/administra-evento.service';
import { AdministrarModel } from '../models/administrar-model';

/**
 * @title Select in a form
 */
interface Status {
  value: string;
  viewValue: string;
}

@Component({
  selector: 'app-administrar-eventos',
  templateUrl: './administrar-eventos.component.html',
  styleUrls: ['./administrar-eventos.component.css']
})
export class AdministrarEventosComponent {

  public titulo: String = 'Administrar Eventos';
  public listarEvento: String = 'Listar Eventos por ID'
  public listarParticipante: String = 'Listar Participante por ID Evento'
  public atualizaStatus: String = 'Atualizar Status do Evento'
  public flagPresente: String = 'Atualizar Flag de Presença';
  public selectedValue: string = '';

  status: Status[] = [
    { value: 'aberto', viewValue: 'Aberto para inscrição' },
    { value: 'andamento', viewValue: 'Em andamento' },
    { value: 'concluido', viewValue: 'Concluido' },
    { value: 'cancelado', viewValue: 'Cancelado' }
  ];

  public IdEventoInput: Number = 0;
  public IdEventoList: Number = 0;
  public IdEventoUpdate: Number = 0;
  public IdEventoFlag: Number = 0;
  public Model = new AdministrarModel();
  listaParticipantes: AdministrarModel[] = [];
  public ModelStatus = new AdministrarModel();
  public ModelFlag = new AdministrarModel();

  mostrarLista: Boolean = false;
  labelPosition: 'before' | 'after' = 'after';

  constructor(private api: AdministraEventoService, private router: Router) {

  }
  ngOnInit(): void {

  }

  get(id:Number, model: String): any{
    this.api.getEventoById(id).subscribe({
      next: (retornoDaApi) => {
        if (model === "box1")
          this.Model = retornoDaApi;
        if(model == "box2")
          this.ModelStatus = retornoDaApi;
        if(model == "box3")
          this.ModelFlag = retornoDaApi;
      }
    });
  }

  clickMostrarLista() {
    this.api.getParticipante(this.IdEventoList).subscribe({
      next: (retornoDaApi) => {
        this.listaParticipantes = retornoDaApi;
      }
    });
    this.mostrarLista = true;
  }


  getUpdate(): any{
    this.api.getEventoStatus(this.IdEventoUpdate).subscribe({
      next: (retornoApi) =>{
        this.ModelStatus = retornoApi;
      }
    });
  }

  getFlag(): any{
    this.api.getEventoFlag(this.IdEventoFlag).subscribe({
      next: (retornoApi) =>{
        this.ModelFlag = retornoApi;
      }
    });
  }
}
