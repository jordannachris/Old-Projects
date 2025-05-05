import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-quadrado',
  templateUrl: './quadrado.component.html',
  styleUrls: ['./quadrado.component.css']
})
export class QuadradoComponent {

  @Input() valorQuadrado!: 'X' | 'O';

}
