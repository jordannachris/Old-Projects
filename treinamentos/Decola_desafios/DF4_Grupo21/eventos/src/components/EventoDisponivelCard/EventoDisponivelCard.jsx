import React, { useState } from "react";
import Card from "@material-ui/core/Card";
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";
import TextField from "@material-ui/core/TextField";
import ButtonEventos from "../button/ButtonEventos";
import "./EventoDisponivelCard.css";
import { CardActions } from "@material-ui/core";
import { postLogin } from "../../services/eventosApiService";
import Snackbar from "@material-ui/core/Snackbar";
import Alert from "../AlertCadastro";

const EventoDisponivelCard = (props) => {
  const [tipoAlert, setTipoAlert] = useState("success");
  const [alert, setAlert] = React.useState();
  const [open, setOpen] = useState(false);
  const [mensagem, setMensagem] = useState(true);
  const [login, setLogin] = useState({
    idEvento: props.propEvento.idEvento,
    Login: "",
  });

  function arrumandoData(dataFeia) {
    let date = new Date(dataFeia);

    let dia = date.getDate();
    let mes = date.getMonth() + 1;
    let ano = date.getFullYear();

    if (dia < 10) {
        dia = '0' + dia;
    }
    if (mes < 10) {
        mes = '0' + mes;
    }
    return dia + "/" + mes + "/" + ano;
}


  function Inscrever(event) {
    event.preventDefault();
    if (event.target.checkValidity()) {
      setLogin({ ...login });
      postLogin(login)
        .then((response) => {
          console.log(response);
          if (response.sucesso === true) {
            setMensagem("Inscrição realizada com sucesso!");
          }
        })
        .catch((error) => {
          if (typeof error.response.data === "string") {
            setTipoAlert("error");
            setMensagem(error.response.data);
          } else {
            setTipoAlert("error");
            setMensagem("Não foi possível realizar a inscrição");
          }
        });
      setOpen(true);
    } else {
      alert("Ocorreu um erro");
    }
  }

  const handleCloseAlert = (event, reason) => {
    if (reason === "clickaway") {
      return;
    }
    setOpen(false);
  };

  return (
    <div>
      <Card className="eventoDisponivelCard">
        <CardContent className="eventoDisponivelCard-content">
          <div className="eventoDisponivelCard-informacoes">
            <Typography
              className="eventoDisponivelCard-informacoes-linhas"
              gutterBottom
              variant="h6"
              component="h2"
            >
              <section className="eventoDisponivelCard-informacoes-linhas-dado">
                Título:
              </section>
              &nbsp;{props.propEvento.nome}
            </Typography>

            <Typography
              className="eventoDisponivelCard-informacoes-linhas"
              gutterBottom
              variant="h6"
              component="h2"
            >
              <section className="eventoDisponivelCard-informacoes-linhas-dado">
                Id Evento:
              </section>
              &nbsp;{props.propEvento.idEvento}
            </Typography>

            <Typography
              className="eventoDisponivelCard-informacoes-linhas"
              gutterBottom
              variant="h6"
              component="h2"
            >
              <section className="eventoDisponivelCard-informacoes-linhas-dado">
                Limite de Vagas:
              </section>
              &nbsp;{props.propEvento.limiteVagas}
            </Typography>

            <Typography
              className="eventoDisponivelCard-informacoes-linhas"
              gutterBottom
              variant="h6"
              component="h2"
            >
              <section className="eventoDisponivelCard-informacoes-linhas-dado">
                Data do evento:
              </section>
              &nbsp;{arrumandoData(props.propEvento.dataHoraInicio)}
            </Typography>
          </div>

          <CardActions className="caralho">
            <form className="formzin" noValidate onSubmit={Inscrever}>
              <TextField
                className="field-nome"
                id="nome"
                label="Digite seu nome"
                variant="outlined"
                value={login.Login}
                onChange={(event) => {
                  setLogin({ ...login, Login: event.target.value });
                }}
              />
              &nbsp;
              <ButtonEventos titulo="Inscrever" />
            </form>
            
          </CardActions>
        </CardContent>
      </Card>
      <Snackbar open={open} autoHideDuration={2000} onClose={handleCloseAlert}>
        <Alert onClose={handleCloseAlert} severity={tipoAlert}>
          {mensagem}
        </Alert>
      </Snackbar>
    </div>
  );
};
export default EventoDisponivelCard;
