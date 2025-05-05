import "./App.css";
import SobrePage from "./pages/SobrePage";
import HomePage from "./pages/HomePage";
import ImoveisPage from "./pages/ImoveisPage";
import ImovelSinglePage from "./pages/ImovelSinglePage";
import ImovelCadastroPage from "./pages/ImovelCadastroPage";
import MenuPageTemplate from "./pageTemplates/MenuPageTemplate";
import { BrowserRouter, Switch, Route } from "react-router-dom";

function App() {
  return (
    <BrowserRouter>
      <MenuPageTemplate>
        <Switch>

          <Route path="/" exact={true}>
            <HomePage />
          </Route>

          <Route path="/imoveis" exact={true}>
            <ImoveisPage />
          </Route>

          <Route path="/imovel/cadastro" exact={true}>
            <ImovelCadastroPage />
          </Route>

          <Route path="/sobre" exact={true}>
            <SobrePage />
          </Route>

          <Route path="/imovel/:id" exact={true}>
            <ImovelSinglePage />
          </Route>

        </Switch>
      </MenuPageTemplate>
    </BrowserRouter>
  );
}

export default App;