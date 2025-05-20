import { TestBed } from '@angular/core/testing';
import { Router } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { authGuard } from './auth.guard';
import { CanActivateFn } from '@angular/router';

describe('authGuard', () => {
  let authServiceSpy: jasmine.SpyObj<AuthService>;
  let routerSpy: jasmine.SpyObj<Router>;
  let guard: CanActivateFn;

  beforeEach(() => {
    authServiceSpy = jasmine.createSpyObj('AuthService', ['isLoggedIn']);
    routerSpy = jasmine.createSpyObj('Router', ['navigate']);

    TestBed.configureTestingModule({
      providers: [
        { provide: AuthService, useValue: authServiceSpy },
        { provide: Router, useValue: routerSpy }
      ]
    });

    guard = (...params) => TestBed.runInInjectionContext(() => authGuard(...params));
  });

  it('should allow when user is logged in', () => {
    authServiceSpy.isLoggedIn.and.returnValue(true);
    const result = guard({} as any, {} as any);
    expect(result).toBeTrue();
  });

  it('should deny and redirect when user is not logged in', () => {
    authServiceSpy.isLoggedIn.and.returnValue(false);
    const result = guard({} as any, {} as any);
    expect(routerSpy.navigate).toHaveBeenCalledWith(['/login']);
    expect(result).toBeFalse();
  });
});
