import { React, useState } from "react";
import Button from '@material-ui/core/Button';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import Checkbox from '@material-ui/core/Checkbox';
import FormControlLabel from '@material-ui/core/FormControlLabel';
import TextField from "@material-ui/core/TextField";
import "./UserRegisterPage.css";


function UserRegisterPage() {

  const [isChecked, setIsChecked] = useState(false);


  const handleChange = () => {
    if (!isChecked) {
      setIsChecked(true);
    }
    else {
      setIsChecked(false);
    }
  };

  return (
    <div className="UserRegisterContainer">
      <Card className="RegisterCard">
        <h1>Cadastro de Usuário</h1>
        <CardContent className="RegisterCardContent">
          <TextField
            className="nome"
            label="Nome de usuário"
            placeholder="Digite seu nome ou apelido"
            variant="outlined"
          />
          <div className="espaco"></div>
          <TextField
            className="email"
            label="E-mail"
            placeholder="Digite o e-mail que usará para fazer login"
            variant="outlined"
          />
          <div className="espaco"></div>
          <TextField
            className="senha"
            label="Senha"
            placeholder="Digite a senha que usará para fazer login"
            variant="outlined"
          />
          <div className="espaco"></div>
          <FormControlLabel
            className="check-box"
            control={
              <Checkbox
                checked={isChecked}
                onChange={handleChange}
                color="primary"
              />
            }
            label="Desejo optar pela conta paga"
          />
          {isChecked ?
            <>
              <div className="espaco"></div>
              <TextField
                className="cartao_credito"
                label="Cartão de Crédito"
                placeholder="Digite o número do seu cartão de crédito"
                variant="outlined"
              />
            </>
            : null
          }
        </CardContent>

        <CardActions className="RegisterCardActions">
          <Button className="botao-cadastro" variant="contained" color="primary">
            Cadastrar Usuário
          </Button>
        </CardActions>
      </Card>
    </div>
  );
}

export default UserRegisterPage;