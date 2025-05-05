import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ListarEventosApiModel } from './listar-eventos-api-model';

@Injectable({
  providedIn: 'root'
})
export class ListarEventoService {

  constructor(private http: HttpClient) { }

  public getListaEventos(): Observable<ListarEventosApiModel[]> {
    return this.http.get<ListarEventosApiModel[]>('https://localhost:44303/api/listareventos');
  }

  getListaEventosByCategoria(idCategoriaEvento: number): Observable<ListarEventosApiModel[]> {
    const apiurl = `https://localhost:44303/api/listareventos/evento/${idCategoriaEvento}`;
    return this.http.get<ListarEventosApiModel[]>(apiurl);
  }

  getListaEventosByData(dataEvento: string): Observable<ListarEventosApiModel[]> {
    const apiurl = `https://localhost:44303/api/ListarEventos/pesquisar/${dataEvento}`;
    return this.http.get<ListarEventosApiModel[]>(apiurl);
  }

}
