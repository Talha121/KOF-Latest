/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PosServiceService } from './PosService.service';

describe('Service: PosService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PosServiceService]
    });
  });

  it('should ...', inject([PosServiceService], (service: PosServiceService) => {
    expect(service).toBeTruthy();
  }));
});
