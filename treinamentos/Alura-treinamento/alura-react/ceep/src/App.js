import React, { Component } from "react";
import ListaDeNotas from "./components/ListaDeNotas";
import FormularioCadastro from "./components/FormularioCadastro";
import "./assets/App.css";
import './assets/index.css';

class App extends Component {

  constructor(){
    super();
    // this.arrayDeNotas = [];
    this.state = { arrayDeNotas:[] };
  }

  criarNota(titulo, texto){
    const novaNota = {titulo, texto};
    const novoArrayNotas = [...this.state.arrayDeNotas, novaNota];

    const novoEstado = {
      arrayDeNotas: novoArrayNotas
    };
    // this.arrayDeNotas.push(novaNota);
    this.setState(novoEstado);
  }

  render() {
    return (
      <section className="conteudo">
        <FormularioCadastro propriedadeCriarNota={this.criarNota.bind(this)}/>
        <ListaDeNotas propriedadeNotas={this.state.arrayDeNotas}/>
      </section>
    );
  }
}

export default App;
