/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { StockinService } from './stockin.service';

describe('Service: Stockin', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [StockinService]
    });
  });

  it('should ...', inject([StockinService], (service: StockinService) => {
    expect(service).toBeTruthy();
  }));
});
