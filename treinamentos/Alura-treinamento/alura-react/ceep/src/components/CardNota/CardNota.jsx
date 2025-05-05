import React, { Component } from "react";
import "./CardNota.css";
import deleteSVG from "../../assets/img/delete.svg";

class CardNota extends Component {
  render() {
    return (
      <section className="card-nota">
        <header className="card-nota_cabecalho">
          <h3 className="card-nota_titulo">{this.props.propriedadeTitulo}</h3>
          <img src={deleteSVG} alt="Ícone de Lixeira"/>
        </header>
        <p className="card-nota_texto">{this.props.propriedadeTexto}</p>
      </section>
    );
  }
}

export default CardNota;
