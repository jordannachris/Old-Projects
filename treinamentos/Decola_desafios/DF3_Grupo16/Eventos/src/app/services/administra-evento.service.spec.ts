import { TestBed } from '@angular/core/testing';

import { AdministraEventoService } from './administra-evento.service';

describe('AdministraEventoService', () => {
  let service: AdministraEventoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AdministraEventoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
