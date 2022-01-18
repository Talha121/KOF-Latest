/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SalesmanService } from './salesman.service';

describe('Service: Salesman', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SalesmanService]
    });
  });

  it('should ...', inject([SalesmanService], (service: SalesmanService) => {
    expect(service).toBeTruthy();
  }));
});
