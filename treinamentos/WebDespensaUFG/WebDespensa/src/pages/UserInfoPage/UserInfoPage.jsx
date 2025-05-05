import React from "react";
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import "./UserInfoPage.css";

function UserInfoPage() {
  return (
    <div className="UserInfoContainer">
      <Card className="UserInfoCard">
        <h1>Dados do Usuário</h1>
        <CardContent className="UserInfoContent">
          <span>Nome:</span>
          <span>E-mail:</span>
          <span>Senha:</span>
          <span>Número do cartão:</span> 
        </CardContent>
      </Card>
    </div>
  );
}

export default UserInfoPage;