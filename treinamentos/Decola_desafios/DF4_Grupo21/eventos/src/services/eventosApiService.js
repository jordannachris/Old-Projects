import axios from "axios";

const urlApi = "https://localhost:44383/api";

export function getEventosDisponiveis() {
  const urlComEventos = urlApi + "/Eventos/disponiveis";

  return axios.get(urlComEventos).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}

export function getEventosByCategoria(idCategoria) {
  const urlComEventosByCategoria =
    urlApi + "/Eventos/" + idCategoria + "/categoria";

  return axios.get(urlComEventosByCategoria).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}

export function getEventosByData(dataEvento) {
   const urlComEventosByData = urlApi + "/Eventos/data/" + dataEvento;

  return axios.get(urlComEventosByData).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}

export function putIniciarEvento(idEvento) {
  return axios.put(`https://localhost:44383/api/Eventos/${idEvento}/iniciar`).then((AxiosResponse) => {
    return AxiosResponse;
  });
}

export function putConcluirEvento(idEvento) {
  return axios.put(`https://localhost:44383/api/Eventos/${idEvento}/concluir`).then((AxiosResponse) => {
    return AxiosResponse;
  });
}

export function putCancelarEvento(idEvento) {
  return axios.put(`https://localhost:44383/api/Eventos/${idEvento}/cancelar`).then((AxiosResponse) => {
    return AxiosResponse;
  });
}

export function postEvento(novo) {
  const eventoPost = {
    nome: novo.Nome,
    dataHoraInicio: novo.DataHoraInicio,
    dataHoraFim: novo.DataHoraFim,
    local: novo.Local,
    descricao: novo.Descricao,
    limiteVagas: novo.LimiteVagas,
    categoria: novo.Categoria,
  };
  return axios
    .post("https://localhost:44383/api/Eventos", eventoPost)
    .then((AxiosResponse) => {
      return AxiosResponse;
    });
}

export function getEventos() {
  return axios
    .get("http://localhost:8080/SistemaEventos")
    .then((AxiosResponse) => {
      return AxiosResponse.data;
    });
}

export function putAvaliacao(novo, id) {
  const AvaliacaoPost = {
    nota: novo.Nota,
    comentario: novo.Comentario,
  };
  return axios
    .put(
      `https://localhost:44383/api/Participacao/${id}/avaliacao`,
      AvaliacaoPost
    )
    .then((AxiosResponse) => {
      return AxiosResponse;
    });
}

export function postLogin(novo) {
  const LoginPost = {
    idEvento: novo.idEvento,
    loginParticipante: novo.Login,
  };
  return axios
    .post("https://localhost:44383/api/Participacao", LoginPost)
    .then((AxiosResponse) => {
      return AxiosResponse.data;
    });
}

export function getParticipantes() {
  return axios
    .get("https://localhost:44383/api/Participacao")
    .then((AxiosResponse) => {
      return AxiosResponse.data;
    });
}

export function getParticipantesById(id) {
  return axios
    .get(`https://localhost:44383/api/Participacao/evento/${id}`)
    .then((AxiosResponse) => {
      return AxiosResponse.data;
    });
}

export function putFlagPresente(idParticipante) {
  return axios
    .put(
      `https://localhost:44383/api/Participacao/${idParticipante}/flagPresente`
    )
    .then((AxiosResponse) => {
      return AxiosResponse;
    });
}
