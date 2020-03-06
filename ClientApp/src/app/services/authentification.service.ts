import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';

import { environment } from '../../environments/environment';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class AuthentificationService {
  private baseUrl = environment.apiUrl;
  private jwtHelper = new JwtHelperService();
  constructor(private http: HttpClient) { }

  register(user: User) {
    return this.http.post(this.baseUrl + 'registration/', user);
  }

  sendConfirmationEmail(user: User) {
    return this.http.post(this.baseUrl + 'send-confirmation/', user);
  }

  login(user: User) {
    return this.http.post(this.baseUrl + 'login/', user).pipe(
      map((response: any) => {
        const res = response;
        if (user) {
          sessionStorage.setItem('token', res.token);
          return res;
        }
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
    if (localStorage.getItem('token')) {
      const tokenPayload = this.getTokenPayload();
      return tokenPayload['role'];
    }
  }

  private getTokenPayload(): string {
    return this.jwtHelper.decodeToken(localStorage.getItem('token'));
  }
}
