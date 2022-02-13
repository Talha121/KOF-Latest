/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { VendorService } from './vendors.service';

describe('Service: Vendors', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [VendorService]
    });
  });

  it('should ...', inject([VendorService], (service: VendorService) => {
    expect(service).toBeTruthy();
  }));
});
