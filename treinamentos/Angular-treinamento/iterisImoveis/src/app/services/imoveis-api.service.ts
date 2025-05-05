import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ImoveisApiModel } from './imoveis-api-model';
import { ImovelApiPostModel } from './imovel-api-post-model';

@Injectable({
  providedIn: 'root'
})
export class ImoveisApiService {

  constructor(private http: HttpClient) { }

  public get(): Observable<ImoveisApiModel[]> {
    return this.http.get<ImoveisApiModel[]>('http://localhost:3000/imoveis');
  }

  public post(endereco: string, vendedor: string, valor: number, imagem: string): Observable<object> {
    const postModel: ImovelApiPostModel = {
      address: endereco,
      image: imagem,
      owner: vendedor,
      price: valor,
      type: 'Venda',
    };
    return this.http.post('http://localhost:3000/imoveis', postModel);
  }

}
