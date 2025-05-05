import { CardContent } from "@material-ui/core";
import Card from "@material-ui/core/Card";
import TextField from "@material-ui/core/TextField";
import { useState } from "react";
import ButtonEventos from "../../components/button/ButtonEventos";
import "./Avaliate.css";
import { useHistory } from "react-router-dom";
import { putAvaliacao } from "../../services/eventosApiService";
import Snackbar from "@material-ui/core/Snackbar";
import Alert from "../../components/AlertCadastro";

const Avaliate = () => {
  let history = useHistory();
  const [tipoAlert, setTipoAlert] = useState("success");
  const [open, setOpen] = useState(false);
  const [mensagem, setMensagem] = useState(true);
  const [id, setId] = useState();

  const [novaAvaliacao, setNovaAvaliacao] = useState({
    Nota: "",
    Comentario: "",
  });

  function Avaliacao(event) {
    event.preventDefault();

    if (event.target.checkValidity()) {
      putAvaliacao(novaAvaliacao, id)
        .then((response) => {
          console.log(response);
          if (response.status === 200) {
            setMensagem("Avaliação cadastrada com sucesso!");
            setTipoAlert('success');
          }
          setTimeout(() => {
            history.push("/");
          }, 1500);
        })
        .catch((error) => {
          if (typeof error.response.data === "string") {
            setMensagem(error.response.data);
            setTipoAlert('error');
          } else {
            setTipoAlert("error");
            setMensagem("Não foi possível realizar o cadastro");
          }
        });
      setOpen(true);
    }
  }
  const handleCloseAlert = (reason) => {
    if (reason === "clickaway") {
      return;
    }
    setOpen(false);
  };

  return (
    <div className="avaliate-container">
      <Card className="avaliate-card">
        <CardContent>
          <form
            noValidate
            autoComplete="off"
            className="avaliate-form"
            onSubmit={Avaliacao}
          >
            <h2 className="texto1">
              Digite seu código de participação e avalie o evento! :)
            </h2>
            <TextField
              className="inferno"
              id="area1"
              variant="outlined"
              label="Digite seu código de participação"
              value={id}
              onChange={(event) => {
                setId(event.target.value);
              }}
            />
            <TextField
              className="inferno"
              id="area2"
              variant="outlined"
              label="Dê sua nota"
              value={novaAvaliacao.Nota}
              onChange={(event) => {
                setNovaAvaliacao({
                  ...novaAvaliacao,
                  Nota: event.target.value,
                });
              }}
            />
            <TextField
              className="inferno"
              multiline rows={4} 
              variant="outlined"
              label="Deixe seu comentário"
              value={novaAvaliacao.Comentario}
              onChange={(event) => {
                setNovaAvaliacao({
                  ...novaAvaliacao,
                  Comentario: event.target.value,
                });
              }}
            />
            <ButtonEventos titulo="Avaliar" />
          </form>
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

export default Avaliate;
