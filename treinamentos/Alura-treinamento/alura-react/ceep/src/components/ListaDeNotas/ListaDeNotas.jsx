import React, { Component } from "react";
import CardNota from "../CardNota";
import "./ListaDeNotas.css";

class ListaDeNotas extends Component {

  // constructor(props){
  //   super(props);
  // }

  render() {
    return (
      <ul className="lista-notas">
        {this.props.propriedadeNotas.map((estadoArrayDeNotas, index) => {
          return (
            <li className="lista-notas_item" key={index}>
              <CardNota propriedadeTitulo={estadoArrayDeNotas.titulo} propriedadeTexto={estadoArrayDeNotas.texto}/>
            </li>
          );
        })}
      </ul>
    );
  }
}

export default ListaDeNotas;
