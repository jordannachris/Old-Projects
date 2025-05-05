import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AdministrarModel } from '../components/models/administrar-model';

@Injectable({
  providedIn: 'root'
})
export class AdministraEventoService {

  constructor(private http: HttpClient) { }
  // public get(): Observable<AdministrarModel[]> {
  //   return this.http.get<AdministrarModel[]>('https://localhost:44303/api/AdministrarEventos/{id}');
  // }
  getEventoById(idEvento: Number): Observable<AdministrarModel> {
    const apiurl = `https://localhost:44303/api/AdministrarEventos/${idEvento}`;
    return this.http.get<AdministrarModel>(apiurl);
  }
  getParticipante(idEvento: Number): Observable<AdministrarModel[]> {
    const apiurl = `https://localhost:44303/api/AdministrarEventos/EventosParticipantes/${idEvento}`;
    return this.http.get<AdministrarModel[]>(apiurl);
  }

  getEventoStatus(idEvento: Number): Observable<AdministrarModel>{
    const apiurlstatus = `https://localhost:44303/api/AdministrarEventos/${idEvento}/Prioridade`;
    return this.http.get<AdministrarModel>(apiurlstatus);
  }

  getEventoFlag(idEvento: Number): Observable<AdministrarModel>{
    const apiurlstatus = `hhttps://localhost:44303/api/AdministrarEventos/${idEvento}/EditarFlagDoParticipante`;
    return this.http.get<AdministrarModel>(apiurlstatus);
  }
}
