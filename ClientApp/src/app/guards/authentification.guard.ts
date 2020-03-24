import { AuthentificationService } from '../services/authentification.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable()
export class AuthentificationGuard implements CanActivate {


  constructor(
    private authentificationService: AuthentificationService){ }

  canActivate(next: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean {
      return this.authentificationService.isAuthentificated();
  }
} 
