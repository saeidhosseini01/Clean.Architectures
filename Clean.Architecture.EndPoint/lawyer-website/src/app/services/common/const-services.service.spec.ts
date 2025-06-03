import { TestBed } from '@angular/core/testing';

import { ConstServicesService } from './const-services.service';

describe('ConstServicesService', () => {
  let service: ConstServicesService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConstServicesService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
