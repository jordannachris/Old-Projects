import axios from "axios";

const urlApi = "https://localhost:44346/api";
const urlUsuario = urlApi + "/Usuario";
const urlProduto = urlApi + "/Produto";

export function getProdutos() {
  return axios.get(urlProduto).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}


export function getUsuarioPorId(id) {
  const urlComId = urlUsuario + "/" + id;
  
  return axios.get(urlComId).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}


export function getUsuarioLogin(email, senha) {
  const urlComLogin = urlUsuario + "/login/" + email + "/" + senha;
  
  return axios.get(urlComLogin).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}


export function postProduto(novo) {
  const produtoPostModel = {
    nome: novo.nome,
  };
  return axios.post(urlProduto, produtoPostModel).then((AxiosResponse) => {
    return AxiosResponse.data;
  });
}