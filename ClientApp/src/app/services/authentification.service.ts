import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';

import { environment } from '../../environments/environment';
import { AuthentificationUser, FacebookAuthUser } from '../models/user';

@Injectable({
  providedIn: 'root'
})

export class AuthentificationService {
  private baseUrl = environment.apiUrl;
  private jwtHelper = new JwtHelperService();

  constructor(private http: HttpClient) { }

  register(user: AuthentificationUser) {
    return this.http.post(this.baseUrl + 'registration/', user);
  }

  sendConfirmationEmail(user: AuthentificationUser) {
    return this.http.post(this.baseUrl + 'send-confirmation/', user);
  }

  login(user: AuthentificationUser) {
    return this.http.post(this.baseUrl + 'login/', user).pipe(
      map((response: any) => {
          sessionStorage.setItem('token', response.token);
          return response;
        }
      ))
  }

  facebookLogin(user: FacebookAuthUser) {
    return this.http.post(this.baseUrl + 'facebook-login/', user).pipe(
      map((response: any) => {
        sessionStorage.setItem('token', response.token);
        return response;
      }
    ))
  }

  isAuthentificated() {
    const token = sessionStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }

  getAuthorizationHeader() {
    return new HttpHeaders().set("Authorization", "Bearer " + sessionStorage.getItem('token'));
  }

  logout() {
    sessionStorage.removeItem('token');
  }

  isAdmin() {
    if (this.getUserRole() === "Administrator") {
      return true;
    }
    else {
      return false;
    }
  }

  private getUserRole(): string {
    if (sessionStorage.getItem('token')) {
      const tokenPayload = this.getTokenPayload();
      return tokenPayload['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'];
    }
  }

  private getTokenPayload(): string {
    return this.jwtHelper.decodeToken(sessionStorage.getItem('token'));
  }
}
