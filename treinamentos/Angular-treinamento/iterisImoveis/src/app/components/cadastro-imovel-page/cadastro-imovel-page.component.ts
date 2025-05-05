import { Component, OnInit } from '@angular/core';
import { MatSnackBar,  MatSnackBarHorizontalPosition,
  MatSnackBarVerticalPosition, } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { ImoveisApiService } from 'src/app/services/imoveis-api.service';

@Component({
  selector: 'app-cadastro-imovel-page',
  templateUrl: './cadastro-imovel-page.component.html',
  styleUrls: ['./cadastro-imovel-page.component.css']
})
export class CadastroImovelPageComponent implements OnInit {
  public endereco = '';
  public vendedor = '';
  public valor = 0;
  public imagemUrl = '';
  public salvando = false;

  constructor(private api: ImoveisApiService, private router: Router, private snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }
  salvar(): void {
    this.salvando = true;
    this.api.post(this.endereco, this.vendedor, this.valor, this.imagemUrl).subscribe({
      next: x => {
        this.router.navigate(['imoveis']);
      },
      error: x => {
        this.salvando = false;
        this.snackBar.open('Aconteceu um erro :/, tente novamente mais tarde!', 'Fechar', {
          duration: 5000,
          horizontalPosition: 'center',
          verticalPosition: 'top',
        });
      }
    });
  }
}
