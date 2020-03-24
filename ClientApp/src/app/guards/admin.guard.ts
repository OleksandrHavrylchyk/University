import { AuthentificationService } from '../services/authentification.service';
import { Injectable } from '@angular/core';
import { CanActivate, Router } from '@angular/router';

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
