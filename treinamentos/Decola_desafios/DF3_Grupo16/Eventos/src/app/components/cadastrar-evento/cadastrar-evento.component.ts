import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CriarEventoServiceService } from 'src/app/services/criar-evento-service.service';
import { CadastraEventoMdel } from '../models/cadastra-evento-mdel';


@Component({
  selector: 'app-cadastrar-evento',
  templateUrl: './cadastrar-evento.component.html',
  styleUrls: ['./cadastrar-evento.component.css']
})
export class CadastrarEventoComponent implements OnInit {
  public model = new CadastraEventoMdel();
  public salvando  =  false;
  constructor(private api: CriarEventoServiceService, private router: Router) { }

  ngOnInit(): void {
  }
  salvar(): void {
    this.salvando = true;
    this.api.post(this.model.IdCategoriaEvento, this.model.Nome, this.model.DataHoraInicio, this.model.DataHoraFim, this.model.Local,  this.model.Descricao, this.model.LimiteDeVagas ).subscribe({
      next: x => {
        alert("Evento cadastrado com sucesso!");
      },
      error: x => {
        this.salvando = false;

      }
    });
  }

}
