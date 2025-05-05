import { Data } from "@angular/router";

export class CadastraEventoMdel {
  IdCategoriaEvento: number = 0;
  Nome: string = "";
  DataHoraInicio = new Date();
  DataHoraFim = new Date();
  Local: string = "";
  Descricao: string = "";
  LimiteDeVagas: number = 0;
}
