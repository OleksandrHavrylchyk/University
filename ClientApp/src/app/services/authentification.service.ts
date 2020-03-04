import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { environment } from '../../environments/environment';
import { User } from '../models/user';

@Injectable({ providedIn: 'root' })
export class AuthentificationService {
  private baseUrl = environment.apiUrl;
  constructor(private http: HttpClient) { }

  register(user: User) {
    return this.http.post(this.baseUrl + 'registration/', user);
  }
  sendConfirmationEmail(user: User) {
    return this.http.post(this.baseUrl + 'send-confirmation/', user);
  }
}
