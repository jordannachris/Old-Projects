import React from "react";
import Button from '@material-ui/core/Button';
import Link from '@material-ui/core/Link';
import { useHistory } from "react-router-dom";
import "./HomePage.css";

function HomePage() {
  let history = useHistory(); 

  const handleNewPage = () => {
    history.push("/usuario/login");
  };

  return (
    <div className="HomeContainer">
      <h1>Web Despensa</h1>
      <h2>O controle da sua despensa, agora online!</h2>
      <img src="images/cart_online.svg" alt="lista de produtos" />
      <Button className="botao-home-login" onClick={handleNewPage} variant="contained" color="primary">
        Login
      </Button>
      <span className="texto-cadastro">
        Não tem uma conta?&nbsp;
        <Link className="link-cadastro" href="/usuario/cadastro">
          Cadastre-se
        </Link>
      </span>
    </div>
  );
}

export default HomePage;