import { TestBed } from '@angular/core/testing';

import { ListarEventoService } from './listar-evento.service';

describe('ListarEventoService', () => {
  let service: ListarEventoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ListarEventoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
