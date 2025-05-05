import Cabecalho from './components/Cabecalho/Cabecalho.jsx'
import Contato from './components/Contato/Contato.jsx';
import Formacao from './components/Formacao/Formacao.jsx';
import Referencias from './components/Referencias/Referencias.jsx';
import Objetivo from './components/Objetivo/Objetivo.jsx';
import Experiencias from './components/Experiencias/Experiencias.jsx';
import Habilidades from './components/Habilidades/Habilidades.jsx';
import "./App.css";

function App() {
  return (
    <div className="container">
      <Cabecalho nomeCabecalho="Jordanna Christina Câmara Costa" cargoCabecalho="Estagiária de Consultoria"></Cabecalho>

      <div className="info">
        <div className="lado-esquerdo">
          <Contato></Contato>
          <Formacao></Formacao>
          <Referencias></Referencias>
        </div>
        <div className="lado-direito">
          <Objetivo></Objetivo>
          <Experiencias></Experiencias>
          <Habilidades></Habilidades>
        </div>
      </div>
    </div>
  );
}

export default App;
