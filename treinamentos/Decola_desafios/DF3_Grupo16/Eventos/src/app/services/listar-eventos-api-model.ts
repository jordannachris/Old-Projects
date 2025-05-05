export interface ListarEventosApiModel {
  idEvento: number;
  idEventoStatus: number;
  idCategoriaEvento: number;
  nome: string;
  dataHoraInicio: string;
  dataHoraFim: string;
  local: string;
  descricao: string;
  limiteVagas: number;
}
