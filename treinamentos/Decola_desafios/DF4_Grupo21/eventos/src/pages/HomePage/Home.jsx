import photo from "../../assets/img-eventese.jpg";
import "../HomePage/Home.css";
import ButtonEventos from "../../components/button/ButtonEventos";
import Avaliate from "../AvaliatePage/Avaliate";
import { useHistory } from "react-router";

export function Home() {

  const history = useHistory();

  function handleClick() {
    history.push("/eventos-disponiveis");
  }

  return (
    <div className="home-container">

      <main id="main-home">
        <div id="vertical1"></div>
        <div id="vertical2"></div>
        <div id="conteudo-home">
          <h1 id="titulo-home">Evente-se</h1>
          <div id="texto-direito">
            <p>Proporcionamos os melhores eventos educacionais na área da tecnologia há 12 anos.</p>
            <p>Temos cursos nas áreas de Backend, Frontend, Mobile, Cloud & DevOps, Modern Workplaces, UI/UX, Data & Analytics e Agilidade & Qualidade.</p>
            <p>Clique no botão e participe dos nossos cursos!</p>
          </div>
          <ButtonEventos titulo="Inscreva-se" onSubmit={Avaliate} id="botao-home" onClick={handleClick}/>
        </div>
        <div id="vertical3"></div>
        <div id="vertical4"></div>
      </main>

      <aside className="lado-esquerdo">
        <img id="photo1" src={photo} alt="foto do inicio" />
      </aside>

    </div >
  );
}

export default Home;
