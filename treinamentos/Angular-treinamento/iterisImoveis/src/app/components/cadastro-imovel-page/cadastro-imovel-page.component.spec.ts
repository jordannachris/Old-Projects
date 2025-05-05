import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CadastroImovelPageComponent } from './cadastro-imovel-page.component';

describe('CadastroImovelPageComponent', () => {
  let component: CadastroImovelPageComponent;
  let fixture: ComponentFixture<CadastroImovelPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CadastroImovelPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CadastroImovelPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
