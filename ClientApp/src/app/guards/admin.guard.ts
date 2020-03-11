import { AuthentificationService } from '../services/authentification.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router, Route } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AdminGuard implements CanActivate {


  constructor(
    private authentificationService: AuthentificationService,
    private router: Router) {}

  canActivate(): boolean {
    if (this.authentificationService.isAdmin()) {
      return true;
    }

    this.router.navigate(['/']);
    return false;
  }
}
