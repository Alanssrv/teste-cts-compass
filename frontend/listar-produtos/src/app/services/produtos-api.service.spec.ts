import { TestBed } from '@angular/core/testing';

import { ProdutosApiService } from './produtos-api.service';

describe('ProdutosApiService', () => {
  let service: ProdutosApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProdutosApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
