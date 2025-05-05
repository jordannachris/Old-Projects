import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AvaliarEventoModel } from '../components/models/avaliar-evento-model';
import { ParticipacoesModel } from '../components/models/participacoes-model';

const httpOptions = {headers: new HttpHeaders({"Content-Type": "application/json"})};
@Injectable({
  providedIn: 'root'
})
export class ParticipacoesService {
  url = 'https://localhost:44303/api/Participacoes';
  public model  = new ParticipacoesModel();
  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }
  public post(idevento: number, loginParticipante: string): Observable<object> {
    const postModel: ParticipacoesModel = {
      idEvento: idevento,
      LoginParticipante: loginParticipante
    };
    return this.http.post(this.url, postModel);
  }

  public put(id:number, idParticipacao: number, nota: number,  descricao: string): Observable<object> {
    this.url= "https://localhost:44303/api/Participacoes/DetalharEvento";
    const apiurl = `${this.url}/${id}`;
    const putModel: AvaliarEventoModel = {
      IdParticipacao: idParticipacao,
      Nota: nota,
      Comentario: descricao
    };
    return this.http.put(apiurl, putModel);
  }

}
