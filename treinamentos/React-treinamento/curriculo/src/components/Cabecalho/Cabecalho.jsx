// import React, { useState } from "react";
import fotoCurriculo from './foto-curriculo.jpg';
import './Cabecalho.css';

function Cabecalho(props) {
  const nomeCabecalho = props.nomeCabecalho ?? "Nome Completo";
  const cargoCabecalho = props.cargoCabecalho ?? "Cargo Atual";
  // const [nome, setNome] = useState("Jordanna");

  return (
    <div className="cabecalho">
      <div className="area-foto">
        <img className="foto-perfil" src={fotoCurriculo} alt="Foto de perfil do currículo"></img> 
      </div>

      <div className="area-nome">
        <h1>{nomeCabecalho}</h1>
        <h2>{cargoCabecalho}</h2>
      </div>
    </div>
  );
}

export default Cabecalho;