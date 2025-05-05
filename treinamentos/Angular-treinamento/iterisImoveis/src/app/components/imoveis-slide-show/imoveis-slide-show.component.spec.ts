import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ImoveisSlideShowComponent } from './imoveis-slide-show.component';

describe('ImoveisSlideShowComponent', () => {
  let component: ImoveisSlideShowComponent;
  let fixture: ComponentFixture<ImoveisSlideShowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ImoveisSlideShowComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ImoveisSlideShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

});
