import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MenuTemplateComponent } from './components/menu-template/menu-template.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { HomePageComponent } from './components/home-page/home-page.component';
import { SobrePageComponent } from './components/sobre-page/sobre-page.component';
import { ImoveisPageComponent } from './components/imoveis-page/imoveis-page.component';
import { HttpClientModule } from '@angular/common/http';
import { MatCardModule } from '@angular/material/card';
import { ImovelCardComponent } from './components/imovel-card/imovel-card.component';
import { ImoveisSlideShowComponent } from './components/imoveis-slide-show/imoveis-slide-show.component';
import { CadastroImovelPageComponent } from './components/cadastro-imovel-page/cadastro-imovel-page.component';
import {MatFormFieldModule} from '@angular/material/form-field';
import { FormsModule } from '@angular/forms';
import {MatInputModule} from '@angular/material/input';
import {MatSnackBarModule} from '@angular/material/snack-bar';

@NgModule({
  declarations: [
    AppComponent,
    MenuTemplateComponent,
    HomePageComponent,
    SobrePageComponent,
    ImoveisPageComponent,
    ImovelCardComponent,
    ImoveisSlideShowComponent,
    CadastroImovelPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatListModule,
    HttpClientModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    MatSnackBarModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
