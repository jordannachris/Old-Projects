import './App.css';
import { eventosContextBuilder } from './services/EventosService';
import EventosContext from './services/EventosContext';
import { useState } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Home } from "./pages/HomePage/Home";
import MenuPageTemplate from "./pageTemplates/MenuPageTemplate";
import EventosDisponiveisPage from './pages/EventosDisponiveisPage';
import CadastrarEvento from "./pages/CadastrarEvento/CadastrarEvento";
import EventosPorCategoriaPage from './pages/EventosPorCategoriaPage/';
import EventosPorDataPage from './pages/EventosPorDataPage/EventosPorDataPage';
import Participantes from './pages/Participantes/Participantes';
import Avaliate from "./pages/AvaliatePage/Avaliate";

function App() {
  const [evento, setEvento] = useState();
  const controleEventos = eventosContextBuilder([evento, setEvento]);

  return (
    <BrowserRouter>
      <MenuPageTemplate>
        <EventosContext.Provider value={controleEventos}>
          <Switch>

            <Route path="/" exact>
              <Home />
            </Route>

            <Route path="/eventos-disponiveis" exact={true}>
              <EventosDisponiveisPage />
            </Route>

            <Route path="/cadastrar" exact>
              <CadastrarEvento />
            </Route>

            <Route path="/avaliate" exact>
              <Avaliate />
            </Route>

            <Route path="/participantes" exact>
              <Participantes />
            </Route>

            <Route path="/eventos/categoria/" exact={true}>
              <EventosPorCategoriaPage />
            </Route>

            <Route path="/eventos/data" exact={true}>
              <EventosPorDataPage />
            </Route>

          </Switch>
        </EventosContext.Provider>
      </MenuPageTemplate>
    </BrowserRouter>
  );
}

export default App;
