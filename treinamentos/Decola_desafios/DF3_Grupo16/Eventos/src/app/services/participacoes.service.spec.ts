import { TestBed } from '@angular/core/testing';

import { ParticipacoesService } from './participacoes.service';

describe('ParticipacoesService', () => {
  let service: ParticipacoesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ParticipacoesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
