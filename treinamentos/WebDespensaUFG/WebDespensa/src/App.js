import "./App.css";
import HomePage from "./pages/HomePage";
import LoginPage from "./pages/LoginPage";
import UserInfoPage from "./pages/UserInfoPage/UserInfoPage";
import UserRegisterPage from "./pages/UserRegisterPage";
import ProductListPage from "./pages/ProductListPage/ProductListPage";
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

          <Route path="/usuario/login" exact={true}>
            <LoginPage />
          </Route>

          <Route path="/usuario/info" exact={true}>
            <UserInfoPage />
          </Route>

          <Route path="/usuario/cadastro" exact={true}>
            <UserRegisterPage />
          </Route>

          <Route path="/produto/lista" exact={true}>
            <ProductListPage />
          </Route>

        </Switch>
      </MenuPageTemplate>
    </BrowserRouter>
  );
}

export default App;