import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ParticipacoesService } from 'src/app/services/participacoes.service';
import { AvaliarEventoModel } from '../models/avaliar-evento-model';
import { ParticipacoesModel } from '../models/participacoes-model';

@Component({
  selector: 'app-participacoes',
  templateUrl: './participacoes.component.html',
  styleUrls: ['./participacoes.component.css']
})

export class ParticipacoesComponent implements OnInit {
  public model = new ParticipacoesModel();
  public avaliarModel = new AvaliarEventoModel();
  public salvando  =  false;
  constructor(private api: ParticipacoesService, private router: Router) { }

  ngOnInit(): void {
  }
  salvar(): void {
    this.salvando = true;
    this.api.post(this.model.idEvento, this.model.LoginParticipante).subscribe({
      next: x => {
        alert("Registro no evento realizado com sucesso!");
      },
      error: x => {
        this.salvando = false;

      }
    });
  }
  salvarUpdate(): void {
    this.salvando = true;
    this.api.put(this.model.idEvento, this.avaliarModel.IdParticipacao, this.avaliarModel.Nota,this.avaliarModel.Comentario).subscribe({
      next: x => {
        alert("Avaliação enviada  com sucesso!");
      },
      error: x => {
        this.salvando = false;
        console.log(x);

      }
    });
  }

}
