export class ListarEventosModel {
  idEvento: number = 0;
  idEventoStatus: number = 0;
  idCategoriaEvento: number = 0;
  nome: string = '';
  dataHoraInicio: Date | undefined;
  dataHoraFim: Date | undefined;
  local: string = '';
  descricao: string = '';
  limiteVagas: number = 0;
}
