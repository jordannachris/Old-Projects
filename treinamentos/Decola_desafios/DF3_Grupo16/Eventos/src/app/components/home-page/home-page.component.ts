import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit {

  public imgUrl = 'https://www.planetabandas.com.br/wp-content/uploads/2018/11/eventos-em-ilhabela.jpg';
  constructor() { }

  ngOnInit(): void {
  }

}
