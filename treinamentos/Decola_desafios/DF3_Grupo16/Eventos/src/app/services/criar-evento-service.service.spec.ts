import { TestBed } from '@angular/core/testing';

import { CriarEventoServiceService } from './criar-evento-service.service';

describe('CriarEventoServiceService', () => {
  let service: CriarEventoServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CriarEventoServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
