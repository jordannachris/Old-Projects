import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CadastraEventoMdel } from '../components/models/cadastra-evento-mdel';

const httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};
@Injectable({
  providedIn: 'root'
})
export class CriarEventoServiceService {
  url = 'https://localhost:44303/api/Eventos';
  constructor(private http: HttpClient) { }

  public post(idcategoriaEvento: number, nome: string, dataHoraInicio: Date, dataHoraFim: Date, local: string, descricao: string, LimiteVagas: number): Observable<object> {
    const postModel: CadastraEventoMdel = {
      IdCategoriaEvento: idcategoriaEvento,
      Nome: nome,
      DataHoraInicio: dataHoraInicio,
      DataHoraFim: dataHoraFim,
      Local: local,
      Descricao: descricao,
      LimiteDeVagas: LimiteVagas,
    };
    return this.http.post(this.url, postModel);
  }
}
