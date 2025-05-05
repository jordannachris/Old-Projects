import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { ContatoComponent } from './components/contato/contato.component';
import { ObjetivoComponent } from './components/objetivo/objetivo.component';
import { FormacaoComponent } from './components/formacao/formacao.component';
import { ExperienciasComponent } from './components/experiencias/experiencias.component';
import { ReferenciasComponent } from './components/referencias/referencias.component';
import { HabilidadesComponent } from './components/habilidades/habilidades.component';
import { CabecalhoComponent } from './components/cabecalho/cabecalho.component';

@NgModule({
  declarations: [
    AppComponent,
    ContatoComponent,
    ObjetivoComponent,
    FormacaoComponent,
    ExperienciasComponent,
    ReferenciasComponent,
    HabilidadesComponent,
    CabecalhoComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
