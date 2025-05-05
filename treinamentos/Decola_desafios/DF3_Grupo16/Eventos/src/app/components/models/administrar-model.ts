export class AdministrarModel {
  idEvento: Number = 0;
  idParticipacao: Number = 0;
  idEventoStatus: Number = 0;
  idCategoriaEvento: Number = 0;
  nome: String = '';
  dataHoraInicio: Date | undefined;
  dataHoraFim: Date | undefined;
  local: String = '';
  descricao: String = '';
  limiteVagas: Number = 0;
  loginParticipante: String = '';
  flagPresente: Number = 0;
  nota: Number = 0;
  comentario: String = '';

}
