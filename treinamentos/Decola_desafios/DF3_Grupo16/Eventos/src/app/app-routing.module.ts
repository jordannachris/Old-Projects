import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './components/home-page/home-page.component';
import { MenuTemplateComponent } from './components/menu-template/menu-template.component';
import { ListarEventosComponent } from './components/listar-eventos/listar-eventos.component';
import { CadastrarEventoComponent } from './components/cadastrar-evento/cadastrar-evento.component';
import { AdministrarEventosComponent } from './components/administrar-eventos/administrar-eventos.component';
import { ParticipacoesComponent } from './components/participacoes/participacoes.component';

const routes: Routes = [{
  path: '',
  component: MenuTemplateComponent,
  children: [
    {
      path: '',
      component: HomePageComponent
    },
    {
      path: 'listareventos',
      component: ListarEventosComponent
    },
    {
      path: 'cadastrar',
      component: CadastrarEventoComponent,
    },
    {
      path: 'participar',
      component: ParticipacoesComponent,
    },
    {
      path: 'administrar',
      component: AdministrarEventosComponent
    }
  ]
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }




