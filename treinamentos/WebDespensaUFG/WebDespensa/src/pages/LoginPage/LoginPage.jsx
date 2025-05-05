import React from "react";
import Button from '@material-ui/core/Button';
import Card from '@material-ui/core/Card';
import CardActions from '@material-ui/core/CardActions';
import CardContent from '@material-ui/core/CardContent';
import Link from '@material-ui/core/Link';
import TextField from "@material-ui/core/TextField";
import "./LoginPage.css";

function LoginPage() {
  return (
    <div className="LoginContainer">
      <Card className="LoginCard">
        <h1>Login</h1>
        <CardContent className="LoginCardContent">
          <TextField
            className="email"
            label="E-mail"
            placeholder="E-mail de login do usuário"
            variant="outlined"
          />
          <div className="espaco"></div>
          <TextField
            className="senha"
            label="Senha"
            placeholder="Senha de login do usuário"
            variant="outlined"
          />
        </CardContent>

        <CardActions className="LoginCardActions">
          <Button className="botao-login" variant="contained" color="primary">
            Login
          </Button>
          <span className="texto-cadastro">
            Não tem uma conta?&nbsp;
            <Link className="link-cadastro" href="/usuario/cadastro">
              Cadastre-se
            </Link>
          </span>
        </CardActions>
      </Card>
    </div>
  );
}

export default LoginPage;